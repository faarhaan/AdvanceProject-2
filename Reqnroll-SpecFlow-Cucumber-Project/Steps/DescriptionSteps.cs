using Reqnroll_SpecFlow_Cucumber_Project.AssertHelpers;
using Reqnroll_SpecFlow_Cucumber_Project.Pages.Components.Profile;
using Reqnroll_SpecFlow_Cucumber_Project.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reqnroll_SpecFlow_Cucumber_Project.Steps
{
    public class DescriptionSteps
    {
        // Path for DescriptionData
        private readonly String addDescriptionPath = "F:\\I-Advance-Github-Projects\\AdvanceProject-2\\Reqnroll-SpecFlow-Cucumber-Project\\TestData\\DescriptionData.json";
        private readonly DescriptionPage descriptionPageObj;
        public DescriptionSteps() 
        {
            descriptionPageObj = new DescriptionPage();
        }

        public void AddDescription()
        {
            //Load data from descriptiondata.json file

            var dataList = JsonDataLoader.LoadData<DescriptionModel>(addDescriptionPath);

            foreach (var data in dataList)
            {
                // Add description code from descriptioPage
                descriptionPageObj.InputDesription(data);
                var descripModel = data.Description;
                Console.WriteLine(descripModel);
                var descripUI = descriptionPageObj.GetDescriptionFromUI(data.Description);
                DescriptionAssertHelper.AssertDescriptionAdded(descripModel, descripUI);
            }
        }
    }
}
