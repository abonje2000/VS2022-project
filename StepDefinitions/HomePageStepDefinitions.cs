using KnowledgePoolAutomation.Drivers;
using KnowledgePoolAutomation.PageObjects;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace KnowledgePoolAutomation.StepDefinitions
{
    [Binding]
    public class HomePageStepDefinitions
    {
        HomePage homePage;

        public HomePageStepDefinitions()
        {
            homePage  = new HomePage();
        }

      

        [Given(@"a user navigate to KnowledgePool")]
        public void GivenAUserNavigateToKnowledgePool()
        {
            homePage.NavigateToWebsite();
        }
    }
}
