using System;
using System.Threading;
using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Helpers;
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

            //To make sure you are on profile page click on profile tab on current page
            IWebElement profile = driver.FindElement(By.CssSelector("#account-profile-section > div > section.nav-secondary > div > a:nth-child(2)"));
            profile.Click();

            //Wait 
            TurnOnWait();


        }

        [When(@"I add a Description")]
        public void WhenIAddADescription()
        {
            // To click on add description icon 

            Wait.ClickableElement(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span", 10);

            IWebElement addDescription = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span"));
            addDescription.Click();



            // To add description we need to clear any previous description first
            IWebElement description = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > div.field > textarea"));
            description.Click();
            description.Clear();
            description.SendKeys("It is a new dummy Description");

            //Save the added description

            IWebElement saveDescription = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > button"));
            saveDescription.Click();



        }

        [Then(@"Actual Description is same as expected description")]
        public void ThenActualDescriptionIsSameAsExpectedDescription()
        {

            // Find Description displaying field on profile page

            IWebElement check = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > span"));
            // check if the above description is added successfully
            Assert.That(check.Text == "It is a new dummy Description", "Description is added");

        }

        [When(@"I check the Seller description Field")]
        public void WhenICheckTheSellerDescriptionField()
        {

            

            // Wait for Description to appear on page
            //Wait.ElementVisible(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > span", 10);
            Thread.Sleep(2000);
            IWebElement check = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > span"));
           

            //Print Description
            
            Console.WriteLine(check.Text);


        }

        [Then(@"Description is visible")]
        public void ThenDescriptionIsVisible()
        {


            //assert that description is visible on page
            IWebElement check = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > span"));
            Assert.That(check.Text != null, "Description is not visible on profile page");

        }


        [When(@"I Click on Edit description icon")]
        public void WhenIClickOnEditDescriptionIcon()
        {


            //To add description click on edit description icon
            Wait.ClickableElement(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span", 10);

            IWebElement addDescription = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span"));
            addDescription.Click();



            // Update description in the field
            IWebElement description = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > div.field > textarea"));
            description.Click();
            description.Clear();
            description.SendKeys("It is an updated Description");

            // Save the addded description
            IWebElement saveDescription = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > button"));
            saveDescription.Click();

        }

        [Then(@"updated Description is same as expected description")]
        public void ThenUpdatedDescriptionIsSameAsExpectedDescription()
        {
            //Updated description is visible
            IWebElement check = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > span"));

            Assert.That(check.Text == "It is an updated Description", "Description is added");



        }


    }
}
