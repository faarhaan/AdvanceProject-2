using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reqnroll_SpecFlow_Cucumber_Project.AssertHelpers
{
    public class DescriptionAssertHelper
    {
        public static void AssertDescriptionAdded(string descripModel, string descripUI)
        {
            Console.WriteLine("descritption model value: " + descripModel);
            Console.WriteLine("descritption UI value: " + descripUI);

            // Normalize both strings by:
            // 1. Replacing multiple spaces with a single space
            // 2. Trimming leading/trailing spaces
            var normalizedModel = System.Text.RegularExpressions.Regex.Replace(descripModel, @"\s+", " ").Trim();
            var normalizedUI = System.Text.RegularExpressions.Regex.Replace(descripUI, @"\s+", " ").Trim();

            Assert.That(normalizedUI, Is.EqualTo(normalizedModel),
                $"Expected description '{descripModel}', but found '{descripUI}'.");
        }
    }

   
}

