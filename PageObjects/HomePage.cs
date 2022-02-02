using KnowledgePoolAutomation.Drivers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgePoolAutomation.PageObjects
{
    class HomePage
    {
        IWebDriver driver;
        public HomePage()
        {
            driver = Hooks.driver;

        }

      



        //IWebElement HelloSignIn => driver.FindElement(By.XPath("//span[text()='Hello, Sign in']"));

        public void NavigateToWebsite()
        {
           driver.Navigate().GoToUrl("https://knowledgepool.reteicons.com/");
        }



    }
}
