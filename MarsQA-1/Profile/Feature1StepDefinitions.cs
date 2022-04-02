using System;
using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class Feature1StepDefinitions : Driver
    {


        [Given(@"I am on Profile page")]
        public void GivenIAmOnProfilePage()
        {
            IWebElement profile = driver.FindElement(By.XPath(""));
              profile.Click();
            TurnOnWait();


        }

        [When(@"I add a Description")]
        public void WhenIAddADescription()
        {
            
            IWebElement addDescription = driver.FindElement(By.XPath("//*[@id=\"account - profile - section\"]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span"));
            addDescription.Click();




            IWebElement description = driver.FindElement(By.XPath("//*[@id=\"account - profile - section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea"));
            description.Click();
            description.SendKeys("It is a dummy Description");


            IWebElement saveDescription = driver.FindElement(By.XPath("//*[@id=\"account - profile - section\"]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            saveDescription.Click();



        }

        [Then(@"Actual Description is same as expected description")]
        public void ThenActualDescriptionIsSameAsExpectedDescription()
        {

            IWebElement check = driver.FindElement(By.XPath("//*[@id=\"account - profile - section\"]/div/section[2]/div/div/div/div[3]/div/div/div/span"));

            Assert.That(  check.Text == "It is a dummy Description", "Description is added" );

        }

        [When(@"I check the Seller description Field")]
        public void WhenICheckTheSellerDescriptionField()
        {
            throw new PendingStepException();
        }

        [When(@"I Click on Edit description icon")]
        public void WhenIClickOnEditDescriptionIcon()
        {
            throw new PendingStepException();
        }





    }
}
