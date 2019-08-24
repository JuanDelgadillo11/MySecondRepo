using Microsoft.VisualStudio.TestTools.UnitTesting;
using PageObjectLibrary.Initializer;
using PageObjectLibrary.Steps.AutomationPractice.Navigation;

namespace FirstTestSolution.Hooks
{
    [TestClass]
    public class Hook:Init
    {
        public NavigationSteps navigationSteps;
        [TestInitialize]
        public void TestSetup()
        {
            OpenBrowser();
            navigationSteps = new NavigationSteps();
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            //CloseBrowser();
        }
    }
}
