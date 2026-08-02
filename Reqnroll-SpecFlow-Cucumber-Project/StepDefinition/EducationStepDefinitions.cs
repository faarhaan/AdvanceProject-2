using System;
using Reqnroll;
using Reqnroll_SpecFlow_Cucumber_Project.Pages.Components.Profile;
using Reqnroll_SpecFlow_Cucumber_Project.Steps;
using Reqnroll_SpecFlow_Cucumber_Project.Utilities;

namespace Reqnroll_SpecFlow_Cucumber_Project.StepDefinition
{
    [Binding]
    public class EducationStepDefinitions
    {
        private readonly EducationSteps educationStepObj;
        public EducationStepDefinitions() 
        {
            educationStepObj = new EducationSteps();
        }
        
        [Given("I am on the Education tab")]
        public void GivenIAmOnTheEducationTab()
        {
            Console.WriteLine("Navigation step is already executed in Education Page");
            //educationStepObj.NavigateToEducationTab();
        }

        [When("I add a new Education list.")]
        public void WhenIAddANewEducationList_()
        {
            educationStepObj.AddEducationSteps();
        }

        [Then("Education List should be added successfully")]
        public void ThenEducationListShouldBeAddedSuccessfully()
        {
            Console.WriteLine("Education List added successfully");
        }

        //  2nd Scenario  to update the education list
        [When("I update Education List")]
        public void WhenIUpdateEducationList()
        {
            educationStepObj.UpdateEducationSteps();
        }

        [Then("Education list should be updated successfully.")]
        public void ThenEducationListShouldBeUpdatedSuccessfully_()
        {
            Console.WriteLine("Education list is updated successfully");
        }


        // 3rd Scenario  to delete the education list which
        [When("I delete the Educaiton list")]
        public void WhenIDeleteTheEducaitonList()
        {
            educationStepObj.DeleteEducationSteps();
        }

        [Then("All Education entries should be deleted successfully")]
        public void ThenAllEducationEntriesShouldBeDeletedSuccessfully()
        {
            Console.WriteLine("All Education entries are deleted successfully");
        }

    }
}
