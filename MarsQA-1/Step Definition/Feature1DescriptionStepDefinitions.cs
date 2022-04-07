using System;
using System.Threading;
using MarsQA_1.Helpers;
using MarsQA_1.Pages;
using MarsQA_1.SpecflowPages.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class Feature1DescriptionStepDefinitions : Driver
    {
        ProfilePage ObjectProfile = new ProfilePage(); 

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

            ObjectProfile.CreateDescription();


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

            ObjectProfile.CheckDescription();


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
            ObjectProfile.Updatedescription();

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
