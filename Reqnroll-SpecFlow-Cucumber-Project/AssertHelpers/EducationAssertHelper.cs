using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reqnroll_SpecFlow_Cucumber_Project.AssertHelpers
{
    public static class EducationAssertHelper
    {
        public static void AssertEducationAdded(string expected, string actual)
        {
            Assert.That(actual, Is.EqualTo(expected), $"Expected education '{expected}', but found '{actual}'.");
        }


        public static void AssertEducationUpdated(EducationModel data)
        {
           Assert.That(data, Is.Not.Null, "Updated education not found.");
           Assert.That(data.University, Is.EqualTo(data.University), "University name mismatch.");
           Assert.That(data.Country, Is.EqualTo(data.Country), "Country mismatch.");
           Assert.That(data.Title, Is.EqualTo(data.Title), "Title mismatch.");
           Assert.That(data.Degree, Is.EqualTo(data.Degree), "Degree mismatch.");
           Assert.That(data.GraduationYear, Is.EqualTo(data.GraduationYear), "Graduation year mismatch.");
        }

        public static void AssertEducationDeleted(string University)
        {
            Assert.That(University, Is.Null, "Education was not deleted.");
        }
    }
}
