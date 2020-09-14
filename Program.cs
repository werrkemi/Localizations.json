using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Localizations
{
    class Program
    {
        static void Main()
        {
            var projectDir = new DirectoryInfo(Directory.GetCurrentDirectory());
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

                    var json = JsonConvert.DeserializeObject(File.ReadAllText(e2.FullName));

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