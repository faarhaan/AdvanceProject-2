using Reqnroll;
using Reqnroll_SpecFlow_Cucumber_Project.AssertHelpers;
using Reqnroll_SpecFlow_Cucumber_Project.Pages.Components.Profile;
using Reqnroll_SpecFlow_Cucumber_Project.Steps;
using Reqnroll_SpecFlow_Cucumber_Project.Utilities;
using System;

namespace Reqnroll_SpecFlow_Cucumber_Project.StepDefinition
{
    [Binding]
    public class CertificationStepDefinitions : BaseClass
    {

        private readonly CertificationSteps certStepObj;
        private readonly CertificationPage certPageObj;

        public CertificationStepDefinitions()
        {
            certStepObj = new CertificationSteps();
            certPageObj = new CertificationPage();
        }

        [Given("I am on the Certifications tab")]
        public void GivenIAmOnTheCertificationsTab()
        {
            certStepObj.NavigateToCertificationTab();
        }

        [When("I add a new certification")]
        public void WhenIAddANewCertification()
        {
            certStepObj.AddCertification();
            
        }

        [Then("The certification should be added successfully")]
        public void ThenTheCertificationShouldBeAddedSuccessfully()
        {
            // As Addcertification handles creation and Assertion so here using console msg
           Console.WriteLine("Certification added successfully");
           
        }

        //   2nd Scenario is to update the Certification List

        [When("I update Certification List")]
        public void WhenIUpdateCertificationList()
        {
            certStepObj.UpdateCertification();
        }

        [Then("Certification list should be updated successfully.")]
        public void ThenCertificationListShouldBeUpdatedSuccessfully_()
        {
            // As assertion for update certificate is already implemented in above method so need here
            Console.WriteLine("Certification list updated successfully");
        }


        //   3rd Scenario  is to Delete the Certification List

        [When("I delete the Certification list")]
        public void WhenIDeleteTheCertificationList()
        {
            certStepObj.DeleteCertification();
        }

        [Then("All Certification should deleted successfully")]
        public void ThenAllCertificationShouldDeletedSuccessfully()
        {
            // As delete Assertion is successfully inserted in above method [delete certification] so skip here
            Console.WriteLine("All Certification deleted successfully");
        }




    }
}
