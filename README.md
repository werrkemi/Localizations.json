# Localizations.json

This is global repository for country-specific reports which are available in [Manager](https://www.manager.io).

## Project structure

Every language has its own folder. For example, English country-specific reports are in `English` folder. Dutch country-specific reports will be in `Nederlands` folder (Nederlands is native language name).

Within each folder, you will see one or more files in `JSON` format. These are Manager businesses which can be imported into Manager. Each country can contain one or more country-specific reports.

If we do not have `JSON` file for your language/country combination, please [create new issue](https://github.com/Manager-io/Localizations.json/issues/new/choose) and we will add it.

Contributing involves three steps:

1. Import JSON
2. Export JSON
3. Upload JSON

## Import JSON

You need to import existing `JSON` file into Manager to get started:

1. [Download the latest version](https://github.com/Manager-io/Localizations.json/archive/master.zip) of this repository in ZIP format.
2. Unzip the archive.
3. Open Manager, click `Add Business` button. Then `Import Business` and select the JSON file from unzipped archive.

Once country-specific business is imported, please see [this forum topic](https://forum.manager.io/t/report-transformations-no-code-development-platform/35804). It explains how you can create country-specific report.

## Export JSON

Exported business to `JSON` format can be submitted to this repository.

Go to `Settings` tab.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/e/6/e669e4226b55ea7886df7db767933b3653fc2d2d.png)

Then click `Report Transformations`

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/f/4/f47a7226858ba13111a5d88d7dcfa95a08f73580.png)

Then click on `Export` button in bottom-right corner.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/b/6/b6a6f7f71d0a693396cc464f1d81b9f7acbf399f.png)

This will reveal screen with `JSON` content. Click `Copy to clipboard` button again so the `JSON` content is in your clipboard.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/5/f/5f3803ff6e9e560ff4128b1be2343dee4e28136a.png)

## Upload JSON

Here on GitHub, click on the language folder where your country resides, then click on `JSON` file of the country you are contributing to. Then click on the little pencil pencil to `Edit` (second last icon).

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/b/c/bc940c6a615642b6b343aadd21f164b8a61933d5.png)

Remove the contents of the file and paste there your new JSON content. Then click on `Preview changes` tab to make sure your changes have been picked up.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/d/b/db96f341ee952e3a03fbcd3a2c93ba0c1244e1c8.png)

Click `Propose changes` button.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/8/d/8d1c463eab9edaa01459661e63f971e7963895fe.png)

Then `Create pull request` button.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/c/4/c4df569b8260a1da5cd936f5d697ca06f2e782f1.png)

And then `Create pull request` button once again.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/2/1/21ac97297c80e0f4a85dcc988f8ccecac7069ea2.png)

Done. Your changes have been submitted.