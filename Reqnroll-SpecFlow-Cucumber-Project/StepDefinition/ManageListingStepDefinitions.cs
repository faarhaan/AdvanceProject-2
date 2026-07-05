using System;
using OpenQA.Selenium.DevTools.V135.Browser;
using RazorEngine.Compilation.ImpromptuInterface;
using Reqnroll;
using Reqnroll_SpecFlow_Cucumber_Project.Pages.Components.ManageListing;
using Reqnroll_SpecFlow_Cucumber_Project.Steps;

namespace Reqnroll_SpecFlow_Cucumber_Project.StepDefinition
{
    [Binding]
    public class ManageListingStepDefinitions
    {   
        private readonly ManageListingSteps manageListingStepsObj;
        private readonly ManageListingPage  manageListingPageObj;
        public  ManageListingStepDefinitions()
        {
            manageListingStepsObj = new ManageListingSteps();       
            manageListingPageObj = new ManageListingPage();
        }
        [Given("Come to the ManageListing tab")]
        public void GivenComeToTheManageListingTab()
        {
            manageListingPageObj.GoToManageListingTab();
        }

        [When("I edit the listing by pencil icon")]
        public void WhenIEditTheListingByPencilIcon()
        {
            manageListingStepsObj.EditManageList();
        }

        [Then("Listing should be updated successfully")]
        public void ThenListingShouldBeUpdatedSuccessfully()
        {
            Console.WriteLine("Listing updated successfully");
        }


        // Next Sceanrio   ::::  To view the listing in new page
        [When("I view the Listing by eye icon")]
        public void WhenIViewTheListingByEyeIcon()
        {
           manageListingStepsObj.ViewedManageList();
        }

        [Then("listin should be visible in new page")]
        public void ThenListinShouldBeVisibleInNewPage()
        {
            Console.WriteLine("Selected listing is viewed successfully in new Page");
        }

        // Delete Scenario :::  Delete the viewed skill from list
        [When("I delete the viewed skill from list")]
        public void WhenIDeleteTheViewedSkillFromList()
        {
            manageListingStepsObj.DeleteSkillMangeList();
        }

        [Then("viewed skill should be deleted successfully")]
        public void ThenViewedSkillShouldBeDeletedSuccessfully()
        {
            Console.WriteLine("Skill should be deleted successfully");
        }

    }
}
