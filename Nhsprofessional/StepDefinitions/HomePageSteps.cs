using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoDi;
using Nhsprofessional.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Nhsprofessional.StepDefinitions
{
    [Binding]
  public  class HomePageSteps : HomePage

    {
        private IWebDriver _driver; 
     
        public HomePageSteps(IWebDriver driver) : base(driver)
        {

            _driver = driver;
        }

        [Given(@"that i am on nhsp website")]
        public void GivenThatIAmOnNhspWebsite()
        {
            SetUp();
            LoginToApp();
        }

        [When(@"i click on logon dropdown")]
        public void WhenIClickOnLogonDropdown()
        {
            Console.WriteLine("Print something");
        }

        [Then(@"i all member apps should present correctly")]
        public void ThenIAllMemberAppsShouldPresentCorrectly()
        {
            ShutDown();
        }

    }
}
