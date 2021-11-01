using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Localizations
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.UTF8Encoding.UTF8;

            var types = new HashSet<Guid>();
            types.Add(new Guid("9a8fc328-7553-469f-88ed-dc533f2160b2")); // Extension
            types.Add(new Guid("dcb382dc-a4e0-4354-a845-b7d647f610f7")); // CustomField
            types.Add(new Guid("91c2bcbb-1f8c-4aa1-82fd-0ab38c97fb14")); // ReportTransformation

            types.Add(new Guid("7f368d97-8b7f-4b39-b156-dc66afd9496a")); // TaxCode
            types.Add(new Guid("73af4c68-c347-4088-8846-758f1e7bc5bb")); // PayslipContributionItem
            types.Add(new Guid("0444eb18-6fc5-4d1f-be8b-c114da01832c")); // PayslipDeductionItem
            types.Add(new Guid("ab02f6ab-c91c-4fc2-b979-66a6682c200e")); // PayslipEarningsItem            
            types.Add(new Guid("6ef13e42-ad89-4d42-9480-546e0c04a411")); // BalanceSheetAccount            
            types.Add(new Guid("5770616c-0e01-46ca-a172-f7042275da6c")); // ProfitAndLossStatementGroup
            types.Add(new Guid("26b9e4a5-ce10-4f30-94c7-23a1ca4428f9")); // ProfitAndLossStatementAccount
            types.Add(new Guid("f361339b-932a-4436-b56e-a337c1587c72")); // SubAccount

            var singletons = new HashSet<Guid>();
            singletons.Add(new Guid("7662b887-c8d8-486e-98fd-f9dbcd41c6dc")); // Receipt form default
            singletons.Add(new Guid("79f99d26-e43a-4ecb-a9c9-0774601a9b2e")); // Payment form default
            singletons.Add(new Guid("39dde4fc-7af8-44cc-8572-3b1ff4cfb918")); // BaseCurrency
            singletons.Add(new Guid("a56e89d1-7bee-4509-8b84-c9ebc3808b0c")); // DateAndNumberFormat

            var projectDir = new DirectoryInfo(Directory.GetCurrentDirectory());
#if DEBUG
            projectDir = projectDir.Parent.Parent.Parent;
#endif
            Console.WriteLine("Project Directory: " + projectDir.FullName);

            var output = new Dictionary<string, Dictionary<string, object>>();

            foreach (var e in projectDir.GetDirectories().OrderBy(x => x.Name))
            {
                if (e.Name.StartsWith('.')) continue;
                if (e.Name == "obj") continue;
                if (e.Name == "bin") continue;

                output.Add(e.Name, new Dictionary<string, object>());

                foreach (var e2 in e.GetFiles("*.json").OrderBy(x => x.Name))
                {
                    Console.WriteLine("Input: "+e2.FullName);

                    var business = JsonConvert.DeserializeObject<Dictionary<Guid, Dictionary<Guid, JObject>>>(File.ReadAllText(e2.FullName));

                    var businessDetailsKey = new Guid("38cf4712-6e95-4ce1-b53a-bff03edad273");
                    if (business.TryGetValue(businessDetailsKey, out Dictionary<Guid, JObject> dict))
                    {
                        if (dict.TryGetValue(businessDetailsKey, out JObject businessDetails))
                        {
                            if (businessDetails.TryGetValue("6", out JToken value))
                            {
                                if (!string.IsNullOrWhiteSpace(value.ToString()))
                                {
                                    throw new Exception("Country must be empty.");
                                }
                            }
                        }
                    }

                    var json = business.Where(x => types.Contains(x.Key) || singletons.Contains(x.Key)).ToDictionary(x => x.Key, x => x.Value);

                    json.SelectMany(x => x.Value).ToDictionary(x => x.Key); // Ensure every object has unique key

                    foreach (var e3 in singletons)
                    {
                        if (json.ContainsKey(e3))
                        {
                            var singleton = json[e3][e3];
                            var singletonDict = new Dictionary<Guid, JObject>();
                            if (singleton != null) singletonDict.Add(e3, singleton);
                            json[e3] = singletonDict;
                        }
                    }

                    var name = Path.GetFileNameWithoutExtension(e2.Name);
                    output[e.Name].Add(name, json);
                }
            }

            var outputJson = JsonConvert.SerializeObject(output, Formatting.Indented);
            var outputPath = Path.Combine(Directory.GetCurrentDirectory(), "Localizations.json");
            Console.WriteLine("Output: " + outputPath);
            File.WriteAllText(outputPath, outputJson);
        }
    }
}