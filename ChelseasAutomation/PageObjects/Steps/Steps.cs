using Core;
using TechTalk.SpecFlow;

namespace PageObjects.Steps
{
    [Binding]
    public sealed class Steps
    {
        private readonly SharedMethods sharedMethods = new SharedMethods();

        [Given(@"I have tested this test when I'm doing something random")]
        public void TestThisTest()
        {
            sharedMethods.NavigateTo("https://github.com/");
        }
    }
}
