using OpenQA.Selenium;
using Reqnroll.Assist;
using Reqnroll_SpecFlow_Cucumber_Project.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reqnroll_SpecFlow_Cucumber_Project.Pages.Components.ManageListing
{
    public class ManageListingPage : CommonDriver
    {

        // Note:  As when we try to edit listing in Manage listing then page is exactly similar to ShareSkill Page

        // Locators as a private fields for edit listing
        private readonly By profileTab = By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/a[2]");
        private readonly By manageListingTab = By.XPath("//a[@class='item' and @href='/Home/ListingManagement']");
        private readonly By editIcon = By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i");
        // below items are for edit page
        private readonly By shareSkillBtn = By.XPath("//*[@id=\"account-profile-section\"]/div/section[1]/div/div[2]/a");
        private readonly By titleTextbox = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[1]/div/div[2]/div/div[1]/input");
        private readonly By descriptionTextbox = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[2]/div/div[2]/div[1]/textarea");
        private readonly By categoryDropdown = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[1]/select");
        private readonly By subCategory = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[3]/div[2]/div/div[2]/div[1]/select");
        private readonly By tags = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[4]/div[2]/div[1]/div/div/div/input");
        private readonly By serviceTypeRadioBtn = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input");
        private readonly By locationTypeRadioBtn = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input");
        private readonly By skillTradeRadioBtn = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[2]/div/div[1]/div/input");
        private readonly By skillExchangeTag = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[8]/div[4]/div[1]/div/div/div/div/input");
        private readonly By active = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[1]/div/input");
        private readonly By hidden = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[10]/div[2]/div/div[2]/div/input");
        private readonly By saveBtn = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[1]");
        private readonly By cancelBtn = By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[11]/div/input[2]");
        // if you want to select radio button from model e.g for Service Type, you have to assign string s variable and then use in if condition mention in below code
        private IReadOnlyList<IWebElement> serviceType; // you hv to define service Type
        string serviceType1 = "Hourly basis service";
        string serviceType2 = "One-off service";


        // Locators for remaining options
        private readonly By eyeIcon = By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[1]/i");
        private readonly By deleteIcon = By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i");
        private readonly By listActivationButton = By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[7]/div/input");
        private readonly By messageBox = By.XPath("/html/body/div[1]");

        // Locators for logic
        private readonly By viewSkillDescriptionWhnPageCompact = By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[4]");
        private readonly By viewSkillDescrpWhenPageOpen = By.XPath("//*[@id=\"service-detail-section\"]/div[2]/div/div[2]/div[1]/div[1]/div[2]/div[2]/div/div/div[1]/div/div/div/div[2]");
        private readonly By lastSkillDeleted = By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]"); 
        private readonly By latesttopSkillByTitle = By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]");
        private readonly By deletemsgBox = By.XPath("/html/body/div[2]/div");
        private readonly By yesBtn = By.XPath("/html/body/div[2]/div/div[3]/button[2]");
        string listActiveMsg = "Service has been activated"; 
           string listDeActiveMsg = "Service has been deactivated";



        // Actions as a method
        // Go to the Manage listing tab
        public void GoToManageListingTab()
        {   
             Thread.Sleep(2000);
            // Click on Profile Tab
            driver.FindElement(profileTab).Click();
            Thread.Sleep(2000);
            driver.FindElement(manageListingTab).Click();

        }
        public void EditManageListing(EditManageListModel item)
        {
            Thread.Sleep(2000);
            // click on edit pencil icon for First listing
            driver.FindElement(editIcon).Click();
            Thread.Sleep(2000);
            //now next page is same as share skill so i am using that code here
            // Input text from model
            driver.FindElement(titleTextbox).Click();
            driver.FindElement(titleTextbox).SendKeys(item.Title);
            // input description from Modlel
            driver.FindElement(descriptionTextbox).SendKeys(item.Description);
            // Select Category
            driver.FindElement(categoryDropdown).SendKeys(item.Category);
            // Select Sub-category
            Thread.Sleep(3000);
            driver.FindElement(subCategory).SendKeys(item.SubCategory);
            // Input tags from Model
            driver.FindElement(tags).SendKeys(item.Tags);
            driver.FindElement(tags).SendKeys(Keys.Enter);
            // Select the appropriate service type radio button
            if (item.ServiceType == serviceType1)
            {
                driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")).Click();
            }
            else if (item.ServiceType == serviceType2)
            {
                driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")).Click();
            }
            else
            {
                throw new Exception("Invalid ServiceType: " + item.ServiceType);
            }



            // driver.FindElement(locationTypeRadioBtn).Click();
            //as below elements are not interactaable so use javaScriptExecuter
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", driver.FindElement(locationTypeRadioBtn));

            // Select the specific date
            IWebElement calendarElement = driver.FindElement(By.XPath("//*[@id=\"service-listing-section\"]/div[2]/div/form/div[7]/div/div[1]/ul[1]/li[4]/a/span[3]"));
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", calendarElement);
            // skill trade radio button
            driver.FindElement(skillTradeRadioBtn).Click();
            // input skill exchange Tag
            driver.FindElement(skillExchangeTag).SendKeys(item.SkillExchange);
            driver.FindElement(skillExchangeTag).SendKeys(Keys.Enter);
            // select active radio button
            driver.FindElement(active).Click();
            // click on Save button
            driver.FindElement(cancelBtn).Click();
        }
        // newly shared skill appears on top of table in Mannage Listing Page so fetch this element
        private readonly By newlyCreatedSkill = By.XPath("//*[@id=\"listing-management-section\"]/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]");
        // now get the text of that share skill for Assertion purpose
        public String GetTopShareSkill()
        {
            try
            {
                Thread.Sleep(2000);
                return driver.FindElement(newlyCreatedSkill).Text;
            }


            catch (NoSuchElementException)
            {
                // Return null if no shareskill is found
                return null;
            }

        }

        // Action2:  To view the listing
        public void ViewListing()
        {
            Thread.Sleep(1000);
            driver.FindElement(eyeIcon).Click();
        }

              // verification Method-1 To get the text of viewed skill when skill is not open in new page
        public string GetViewedSkillDescriptionWhnPageCompact()
        {
            Thread.Sleep(3000);
            driver.FindElement(manageListingTab).Click();
            Thread.Sleep(2000);
            return driver.FindElement(viewSkillDescriptionWhnPageCompact).Text;
        }

             // Verification Method- 2 To get the text fo viewed skill when skill is open in new page

        public string GetViewedSkillDescriptionWhnPageOpen()
        {
            Thread.Sleep(1000);
            return driver.FindElement(viewSkillDescrpWhenPageOpen).Text;
        }

        // Action3: Delete the viewed Skill

        public void DeleteViewSkill()
        {
            Thread.Sleep(1000);
            driver.FindElement(deleteIcon).Click();
            // message box appear to ask Are you sure to delete this skill, press yes
            Thread.Sleep(2000);
            driver.FindElement(yesBtn).Click();
        }

        public string lastDeletedSkillByTitle()
        { 
            Thread.Sleep(1000);
            return driver.FindElement(lastSkillDeleted).Text;
        }
        public string LatestTopSkill()
        {
            Thread.Sleep(1000);
            return driver.FindElement(latesttopSkillByTitle).Text;
        }

    } 
}
