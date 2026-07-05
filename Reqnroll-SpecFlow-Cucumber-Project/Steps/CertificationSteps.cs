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
    public class CertificationSteps : BaseClass
    {
        // File paths 
        private readonly string addCertificationsPath = "F:\\I-Advance-Github-Projects\\AdvanceProject-2\\Reqnroll-SpecFlow-Cucumber-Project\\TestData\\certifications.json";
        private readonly string updateCertificationsPath = "F:\\I-Advance-Github-Projects\\AdvanceProject-2\\Reqnroll-SpecFlow-Cucumber-Project\\TestData\\certifications-update.json";
        private readonly string deleteCertificationsPath = "F:\\I-Advance-Github-Projects\\AdvanceProject-2\\Reqnroll-SpecFlow-Cucumber-Project\\TestData\\certification_delete.json";


        private readonly CertificationPage certPage;

        public CertificationSteps()
        {
            certPage = new CertificationPage();
        }

        // above method is created in order to avoid repetion of certpageobj for every test cases
        public void AddCertification()
        {

            // Load data
            var dataList = JsonDataLoader.LoadData<CertificationModel>(addCertificationsPath);
            //var certPage = new CertificationPage();

            foreach (var data in dataList)
            {

                // ***  Add certification  from the certification Page POM****
                certPage.InputCertifications(data);

                // Get last certificate text from the UI
                var lastCertificate = certPage.GetLastCertificate(data.Certificate, data.From, data.Year);
                // Log the comparison for debugging
                Console.WriteLine(data.Certificate + "is data.Cetificate from Model");
                Console.WriteLine(lastCertificate + "is last certificate from table");
                // Assert that the certification was added successfully
                CertificationAssertHelper.AssertCertificationAdded(data.Certificate, lastCertificate);
            }

 
        }
        public void UpdateCertification()
        {
            // Load data with original and new values
            var dataList = JsonDataLoader.LoadData<CertificationModel>(updateCertificationsPath);
            // var certPage = new CertificationPage();

            foreach (var data in dataList)
            {
                // Call the updated method, which finds the certificate by its original name
                certPage.UpdateCertificate(data);

                // Wait for UI to refresh
                Thread.Sleep(2000);

                // Retrieve the updated certificate name directly as a string
                var updatedCertificateName = certPage.GetLastCertificate(data.OriginalCertificate, data.From, data.Year);

                // Verify that the updated certificate name matches the expected value
                CertificationAssertHelper.AssertCertificationUpdated(data.OriginalCertificate, updatedCertificateName);

                // Log success Mesage
                Console.WriteLine($"Certificate '{data.OriginalCertificate}' updated to '{data.Certificate}' successfully.");
            }
        }
        public void DeleteCertification()
        {
            // Load the data that was used for the update, as these are the current certificate names
            var dataList = JsonDataLoader.LoadData<CertificationModel>(deleteCertificationsPath);
            //var certPage = new CertificationPage();

            foreach (var data in dataList)
            {
                // Delete the certificate using its current name
                certPage.DeleteCertificate(data);

                // Verify that the certificate is no longer present
                var deletedCertificate = certPage.GetCertificateDetails(data.Certificate);

                // Assert that the certificate is null (i.e., deleted)
                CertificationAssertHelper.AssertCertificationDeleted(deletedCertificate?.Certificate);

                Console.WriteLine($"Certificate '{data.Certificate}' is deleted.");
            }
        }

        public void NavigateToCertificationTab()
        {
            // Go to the Certificate tab
            driver.FindElement(certPage.certificationTab).Click();
        }





    }
}
