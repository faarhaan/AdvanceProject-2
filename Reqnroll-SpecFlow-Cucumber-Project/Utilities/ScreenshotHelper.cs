using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reqnroll_SpecFlow_Cucumber_Project.Utilities
{
    public static class ScreenshotHelper
    {
        public static string CaptureScreenshot(IWebDriver driver, string screenshotName = "Screenshot")
        {
            // Define the custom screenshots directory
            string screenshotsDir = @"F:\I-Advance-Github-Projects\AdvanceProject-2\Reqnroll-SpecFlow-Cucumber-Project\Screenshots";

            // Create the directory if it doesn't exist
            if (!Directory.Exists(screenshotsDir))
            {
                Directory.CreateDirectory(screenshotsDir);
            }

            // Create a unique filename with timestamp
            string fileName = $"{screenshotName}_{DateTime.Now:yyyyMMdd_HHmmss}.png";
            string filePath = Path.Combine(screenshotsDir, fileName);

            // Take screenshot and save
            Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            screenshot.SaveAsFile(filePath);

            // Log the screenshot path for debugging
            Console.WriteLine($"Screenshot saved at: {filePath}");

            return filePath;
        }
    }
}
