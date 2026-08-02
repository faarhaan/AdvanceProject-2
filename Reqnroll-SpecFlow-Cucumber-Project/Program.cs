/*using System;
using Reqnroll_SpecFlow_Cucumber_Project.Utilities;
using Reqnroll_SpecFlow_Cucumber_Project.Pages;
using Reqnroll_SpecFlow_Cucumber_Project.Steps;

namespace Reqnroll_SpecFlow_Cucumber_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Starting the application...");

            // Initialize the driver and setup
            BaseClass baseClass = new BaseClass();
            baseClass.OneTimeSetup();
            baseClass.setUp();

            try
            {
                // Example: Run the Add Certification functionality
                CertificationSteps certificationSteps = new CertificationSteps();
                certificationSteps.AddCertification();

                Console.WriteLine("Certification added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Tear down the driver and flush reports
                baseClass.TearDown();
                baseClass.OneTimeTearDown();
            }

            Console.WriteLine("Application execution completed.");
        }
    }
}
*/