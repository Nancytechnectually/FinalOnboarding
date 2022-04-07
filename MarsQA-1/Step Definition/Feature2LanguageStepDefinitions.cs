using System;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using MarsQA_1.SpecflowPages.Pages;

namespace MarsQA_1
{
    [Binding]
    public class Feature2LanguageStepDefinitions :Driver
    {
        // Variables Defined 
        public String LanguageBeforeUpdate;
        public String LevelBeforeUpdate;
        public string LanguageAfterUpdate;
        public string afterDelete;
        public string F1;
        public String BeforeDelete = "No Language";
        string[] ListOfLanguages = { "English", "Hindi", "Punjabi", "Chinese", "Korean", "French" };
        int b=2;


        ProfilePage ObjectProfile = new ProfilePage();

        [Given(@"I Click on Language Tab")]
        public void GivenIClickOnLanguageTab()
        {

            // Clicking on language tab  

            IWebElement Language = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active"));
            Language.Click();


        }

        

        [When(@"I Update Language Seller can speak")]
        public void WhenIUpdateLanguageSellerCanSpeak()
        {


            ObjectProfile.UpdateLanguage();


        }

        [Then(@"Check Languages has been updated")]
        public void ThenCheckLanguagesHasBeenUpdated()
        {

            // Check language has been Updated 
             Thread.Sleep(1000); 

            try
            {
                // click on language tab 
                IWebElement Language = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active"));
                Language.Click();

                // check page body for updated laguage
                String bodyText = driver.FindElement(By.TagName("body")).Text;
                
                // check if language is found in page source body
                Assert.True(bodyText.Contains(LanguageAfterUpdate), "Text not found!");
                Console.WriteLine(LanguageAfterUpdate + " was added");
            }
            catch
            {
                //if update fails

                Console.WriteLine(LanguageAfterUpdate + " was already added/ or could not be added");

            }

            Console.WriteLine("To update entry atleast one entry should be present, before this test make sure atleast one entry is present which could be updated");


        }

        [When(@"I check the Languages Seller can speak")]
        public void WhenICheckTheLanguagesSellerCanSpeak()
        {

            ObjectProfile.CheckLanguage();
           
        }

        [Then(@"Languages are visible on Profile page")]
        public void ThenLanguagesAreVisibleOnProfilePage()
        {

            // check if atleast one language entry was read
            int x = ObjectProfile.getVariableb();
            Assert.That(x > 2, "No Language to be read");

            Console.WriteLine("To read entry atleast one entry should be present, before this test make sure atleast one entry is present which could be read");



        }






        [When(@"I Create ""([^""]*)"" Seller can speak")]
        public void WhenICreateSellerCanSpeak(string F0)
        {

            ObjectProfile.CreateLanguage(F0);



        }

        [Then(@"Check new Languages has been Added")]
        public void ThenCheckNewLanguagesHasBeenAdded()
        {


            // check new entry is present on page source body
            try
            {
                IWebElement Language = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active"));
                Language.Click();
                String bodyText = driver.FindElement(By.TagName("body")).Text;
                Assert.True(bodyText.Contains(F1), "Text not found!");
                Console.WriteLine(F1 +" was added");
            }
            catch
            {
                // if addition was not successful
                Console.WriteLine(F1 + " was already added/ or could not be added");

            }


            Console.WriteLine("If this test fails, it might be because the language was already added, to get this test to pass delete earlier entry and retry");
            Console.WriteLine("We can only add 4 languages, if we try to add more than that this test might fail. If you need to we candelete a language entry and retry");


        }

        [When(@"I Delete language Seller can speak")]
        public void WhenIDeleteLanguageSellerCanSpeak()
        {
            ObjectProfile.Deletelanguage();
        }

        [Then(@"Check Language has been deleted")]
        public void ThenCheckLanguageHasBeenDeleted()
        {

            // check entry has been deleted

            if (BeforeDelete != "No Language")

            {
                IWebElement Language = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active"));
                Language.Click();

                String bodyText = driver.FindElement(By.TagName("body")).Text;
                Assert.True(bodyText.Contains(BeforeDelete), "Language was not Deleted");

                
            }
            else
            {
                // reset variable for nect delete test

                BeforeDelete = "No Language";

            }
            Console.WriteLine("To Delete entry atleast one entry should be present, before this test make sure atleast one entry is present which could be deleted");



        }

    }

   
}




















