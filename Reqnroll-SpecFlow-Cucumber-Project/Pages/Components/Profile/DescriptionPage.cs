using OpenQA.Selenium;
using Reqnroll_SpecFlow_Cucumber_Project.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reqnroll_SpecFlow_Cucumber_Project.Pages.Components.Profile
{
    public class DescriptionPage : CommonDriver
    {
        // Locators as private fields
        private readonly By profileTab = By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]");
        private readonly By descriptionEditIcon = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i");
        private readonly By descriptionBox = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea");
        private readonly By saveButton = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button");
        private readonly By descriptionText = By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span");
        // Actions as Methods

        public void InputDesription(DescriptionModel model)
        {
            // Switch to Profile Tab
            driver.FindElement(profileTab).Click();

            // Click on the Description Edit Icon
            Thread.Sleep(1000);
            driver.FindElement(descriptionEditIcon).Click();

            // Activate the description box using click
            driver.FindElement(descriptionBox).Click();

            // optional: Remove the text in description if it is previously available
            driver.FindElement(descriptionBox).Clear();

            // Enter the data in descritpion box using its model
            driver.FindElement(descriptionBox).SendKeys(model.Description);

            // Save the Description
            driver.FindElement(saveButton).Click();
            Thread.Sleep(1000);
        }

        //Get description text from UI
        public String GetDescriptionFromUI(String Description)
        {
            //  Trim the text from description and save
            string descripText = driver.FindElement(descriptionText).Text.Trim();
            return descripText;
        }
        
        // Get descriiption text from model
        public void GetdescriptionFrmModel()
        {
            //
        }
    }
}
