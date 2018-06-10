using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;


namespace Nhsprofessional.Pages
{
   public class HomePage
    { 
       public IWebDriver Driver;
       public string BaseUrl;

       public HomePage(IWebDriver driver)
       {
           RetryingElementLocator retry = new RetryingElementLocator(driver, TimeSpan.FromSeconds(30));
           IPageObjectMemberDecorator decor = new DefaultPageObjectMemberDecorator();
            PageFactory.InitElements(retry.SearchContext, Driver, decor);
       }
        
       [FindsBy(How = How.XPath, Using = "//*[@class='dropdown-arrow']")]
       private IWebElement HomelogText { get; set; }
       
        
       public void LoginToApp()
       {
           HomelogText.Click();
       }

       public void SetUp()
       {
           Driver = new ChromeDriver();
           BaseUrl = "https://www.nhsprofessionals.nhs.uk/";
           Driver.Navigate().GoToUrl(BaseUrl);
       }

       public void ShutDown()
       {
           Driver.Close();
       }
   }
}
