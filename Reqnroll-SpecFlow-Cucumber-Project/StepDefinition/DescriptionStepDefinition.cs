using Reqnroll;
using Reqnroll_SpecFlow_Cucumber_Project.Steps;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reqnroll_SpecFlow_Cucumber_Project.StepDefinition
{
    [Binding]
    public class DescriptionStepDefinition
    {
        private readonly DescriptionSteps descrpStepsObj;
        public DescriptionStepDefinition()
        {
             descrpStepsObj = new DescriptionSteps();
        }

        [Given("Profile tab should be active.")]
        public void GivenProfileTabShouldBeActive_()
        {
            Console.WriteLine("Profile tab is already active");
        }

        [When("Add and update description at same time.")]
        public void WhenAddAndUpdateDescriptionAtSameTime_()
        {
            descrpStepsObj.AddDescription();
        }

        [Then("description should be added successfully")]
        public void ThenDescriptionShouldBeAddedSuccessfully()
        {
            Console.WriteLine("Description is added successfully");
        }



    }
}
