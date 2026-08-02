using OpenQA.Selenium;
using Reqnroll_SpecFlow_Cucumber_Project.AssertHelpers;
using Reqnroll_SpecFlow_Cucumber_Project.Pages.Components.ManageListing;
using Reqnroll_SpecFlow_Cucumber_Project.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reqnroll_SpecFlow_Cucumber_Project.Steps
{
    public class ManageListingSteps
    {
        //  json data path for editManageListing
        private readonly string addEditListingPath = "F:\\I-Advance-Github-Projects\\AdvanceProject-2\\Reqnroll-SpecFlow-Cucumber-Project\\TestData\\editManageListingData.json";
        private readonly ManageListingPage manageListingPageObj;
        public ManageListingSteps()
        {
          manageListingPageObj = new ManageListingPage();
        }

        public void EditManageList()
        {
            // Load json data
          var dataList = JsonDataLoader.LoadData<EditManageListModel>(addEditListingPath);
            // if we have only 1 dataset in json file, instead of for each loop, we use this
            manageListingPageObj.EditManageListing(item: dataList[0]);

            var topskillTitle = manageListingPageObj.GetTopShareSkill();
            Console.WriteLine(topskillTitle + " is sharedSkill from UI");

            ManageListingAssertHelper.AssertEditManageListing(dataList[0].Title, topskillTitle);
        }

        public void ViewedManageList()
        {   
            //  As it is simply handled so no json data for it just call simple method to view listing
            manageListingPageObj.ViewListing();

            string viewSklOpenPage = manageListingPageObj.GetViewedSkillDescriptionWhnPageOpen();
            string viewSklCompact = manageListingPageObj.GetViewedSkillDescriptionWhnPageCompact();

            ManageListingAssertHelper.AssertViewManageListing(viewSklCompact,viewSklOpenPage);

        }

        public void DeleteSkillMangeList()
        {
            manageListingPageObj.DeleteViewSkill();

            string lastSkilDeleted = manageListingPageObj.lastDeletedSkillByTitle();
            string latestTopSkil = manageListingPageObj.LatestTopSkill();

            ManageListingAssertHelper.AssertViewManageListing(lastSkilDeleted, latestTopSkil);

        }
    }
}
