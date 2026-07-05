using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reqnroll;
using Reqnroll_SpecFlow_Cucumber_Project.Utilities;

namespace Reqnroll_SpecFlow_Cucumber_Project.Hooks
{

        [Binding]
        public class SpecFlowHooks : BaseClass
        {
            [BeforeTestRun]
            public static void BeforeTestRun()
            {
                // Call OneTimeSetup from BaseClass
                BaseClass baseClass = new BaseClass();
                baseClass.OneTimeSetup();
            }

            [BeforeScenario]
            public void BeforeScenario()
            {
                // Call SetUp from BaseClass before each scenario
                setUp();
            }

            [AfterScenario]
            public void AfterScenario()
            {
                // Call TearDown from BaseClass
                TearDown();
            }

            [AfterTestRun]
            public static void AfterTestRun()
            {
                // Call OneTimeTearDown from BaseClass
                BaseClass baseClass = new BaseClass();
                baseClass.OneTimeTearDown();
            }
        }
    
}
