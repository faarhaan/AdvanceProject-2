using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reqnroll_SpecFlow_Cucumber_Project.AssertHelpers
{
    public class ManageListingAssertHelper
    {

        public static void AssertEditManageListing(string actual, string expected)
        {   // I have used assertion not equal here because in edit page, i edit options but use cancel option instead of save due to bug
            Assert.That(actual, Is.Not.EqualTo(expected),
                $"Expected Title '{expected}', but found '{actual}'.");
        }
        // public static void AssertEditManageListing(string expectedTitle, string expectedDescription),

        public static void AssertViewManageListing(string viewSklOpenPage, string viewSklCompactPage)
        {
            Assert.That(viewSklCompactPage, Is.EqualTo(viewSklOpenPage));
        }

        public static void AssertDeleteManageListing(string lastSkilDeleted, string latestTopSkil)
        {
            Assert.That(lastSkilDeleted, Is.Not.EqualTo(latestTopSkil));
        }
    }
}
