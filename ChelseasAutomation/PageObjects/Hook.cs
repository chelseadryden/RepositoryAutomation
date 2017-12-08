using Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace PageObjects
{
    [Binding]
    [TestClass]
    public sealed class Hook
    {
        private static SharedMethods sharedMethods;


        [BeforeScenario]
        public void BeforeScenario()
        {
            sharedMethods = new SharedMethods();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            sharedMethods.CloseDriver();
        }
    }
}
