using Reqnroll_SpecFlow_Cucumber_Project.AssertHelpers;
using Reqnroll_SpecFlow_Cucumber_Project.Pages.Components.Profile;
using Reqnroll_SpecFlow_Cucumber_Project.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Reqnroll_SpecFlow_Cucumber_Project.Steps
{
    public class EducationSteps : BaseClass
    {
        // File paths for EducationSteps if any
        private readonly string addEducationPath = "F:\\I-Advance-Github-Projects\\AdvanceProject-2\\Reqnroll-SpecFlow-Cucumber-Project\\TestData\\education.json";
        private readonly string updateEducationPath = "F:\\I-Advance-Github-Projects\\AdvanceProject-2\\Reqnroll-SpecFlow-Cucumber-Project\\TestData\\education-update.json";
        private readonly string deleteEducationPath = "F:\\I-Advance-Github-Projects\\AdvanceProject-2\\Reqnroll-SpecFlow-Cucumber-Project\\TestData\\education-delete.json";
        private readonly EducationPage educationPageObj;
        public EducationSteps() 
        { 
            educationPageObj =  new EducationPage();
        }

        public void AddEducationSteps() 
        {
            // Load data
            var dataList = JsonDataLoader.LoadData<EducationModel>(addEducationPath);
            foreach (var data in dataList)
            {

                // ***  Add Education  from the certification Page POM****
                educationPageObj.InputEducation(data);

                // Get last University text from the UI
                var lastUniversity = educationPageObj.GetLastUniversity(data.University, data.Country, data.Title, data.Degree, data.GraduationYear);
               
                // Assert that the certification was added successfully
                EducationAssertHelper.AssertEducationAdded(data.University, lastUniversity);
                
            }
        }

        public void UpdateEducationSteps()
        {
            var dataList = JsonDataLoader.LoadData<EducationModel>(updateEducationPath);

            foreach (var data in dataList)
            {
                // update education from the POM Page
                educationPageObj.UpdateEducation(data);

                // Get last University text from the UI
                var updatedUniversity = educationPageObj.GetLastUniversity(data.University, data.Country, data.Title, data.Degree, data.GraduationYear);

                // Apply Assertions
                EducationAssertHelper.AssertEducationUpdated(data);
            }
        }
         

        public void DeleteEducationSteps()
        {
            var dataList = JsonDataLoader.LoadData<EducationModel>(deleteEducationPath);
            foreach (var data in dataList)
            {
                // Delete education list 
                educationPageObj.DeleteEducation(data);

                var deletedUniversity = educationPageObj.GetEducationDetails(data.University);
                // Apply Assertions
                EducationAssertHelper.AssertEducationDeleted(deletedUniversity?.University);
            }
        }

        public void NavigateToEducationTab()
        {
            // Go to education tab
            driver.FindElement(educationPageObj.educationTab).Click();
        }
    }
}
