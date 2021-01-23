# Localizations.json

This is global repository for country-specific reports which are available in [Manager](https://www.manager.io).

## Tutorial

Anybody can contribute. Try the following tutorial to learn the workflow.

In this tutorial, we are in New Zealand and would like to rename balance sheet account `GST payable` to `GST liability`.

Go to `English` directory of this repository and click on `New Zealand.json` which represents Manager database for New Zealand in JSON format.

Obtain URL of `Raw` button.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/b/c/bc940c6a615642b6b343aadd21f164b8a61933d5.png)

Then open Manager, click `Add Business` button. Then `Import Business` and select `Import business from a URL` tab. Then paste URL obtained from `Raw` button above into Manager.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/3/4/345bfd73b0234a0089b1703aa2a40143fb3b6245.png)

Then click `Import Business` button. After importing, you will be taken to the list of businesses and `New Zealand.json` should appear.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/e/e/ee34f8d8a9907b96c5f70cae4d42fef53c60cd1d.png)

Congratulations. You have imported your first business from global repository. Now you can make new additions and improvements.

In this case, we do not want to do much. Just rename `GST payable` to `GST liability`. So we go to `Settings` tab, then `Chart of Accounts` and rename the account.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/5/0/50c9eeacd92f5d885ff6859a243eab2d91fbb2d3.png)

Once we are done. We need to export this business back to `JSON` format so we can upload it back to global repository.

Go to `Settings` tab.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/e/6/e669e4226b55ea7886df7db767933b3653fc2d2d.png)

Then click `Report Transformations`

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/f/4/f47a7226858ba13111a5d88d7dcfa95a08f73580.png)

Then click on `Export` button in bottom-right corner.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/b/6/b6a6f7f71d0a693396cc464f1d81b9f7acbf399f.png)

This will reveal screen with `JSON` content. Click `Copy to clipboard` button again so the `JSON` content is in your clipboard.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/5/f/5f3803ff6e9e560ff4128b1be2343dee4e28136a.png)

Now come back to GitHub to the same screen where you had `New Zealand.json` open with `Raw` button. But this time, click on the little pencil pencil to `Edit` (second last icon).

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/b/c/bc940c6a615642b6b343aadd21f164b8a61933d5.png)

Remove the contents of the file and paste there your new JSON content. Then click on `Preview changes` tab to make sure your changes have been picked up.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/d/b/db96f341ee952e3a03fbcd3a2c93ba0c1244e1c8.png)

In this case we only renamed `GST payable` to `GST liability` so that's all we should see.

Click `Propose changes` button.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/8/d/8d1c463eab9edaa01459661e63f971e7963895fe.png)

Then `Create pull request` button.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/c/4/c4df569b8260a1da5cd936f5d697ca06f2e782f1.png)

And then `Create pull request` button once again.

![](https://aws1.discourse-cdn.com/business5/uploads/manager1/original/3X/2/1/21ac97297c80e0f4a85dcc988f8ccecac7069ea2.png)

Congratulations. Your proposal to make change to global repository has been created. We will review your proposed changes and merge them so they will be available to everyone.
