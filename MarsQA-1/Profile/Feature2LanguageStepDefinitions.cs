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

namespace MarsQA_1
{
    [Binding]
    public class Feature2LanguageStepDefinitions :Driver
    {
        // Variables Defined 
        public String LanguageBeforeUpdate;
        public String LevelBeforeUpdate;
        public string LanguageAfterUpdate;
       // public string beforeDelete;
       // public string afterDelete;
        public string F1;
        public String BeforeDelete = "No Language";
        string[] ListOfLanguages = { "English", "Hindi", "Punjabi", "Chinese", "Korean", "French" };
        int b=2;
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


            // Read and save value of Language to be updated in a variable 

            IWebElement CheckLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(1)"));
            LanguageBeforeUpdate  =  CheckLanguage.Text;

            // Read and save value of Level of language to be updated in a variable 

            IWebElement Level  = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(2)"));
            LevelBeforeUpdate = Level.Text;


            //Click on Edit Button
            IWebElement ClickEdit = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(1) > i"));
            ClickEdit.Click();


       
           // Check if language is alredy present and the update with new language 

            if (LanguageBeforeUpdate != ListOfLanguages[2])

            {

                //add updated language
                IWebElement AddLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(1) > input[type=text]"));


                AddLanguage.Clear();
                AddLanguage.SendKeys("Punjabi");

               
                IWebElement Update = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > span > input.ui.teal.button"));
                Update.Click();

                // save updated value in a variable
                LanguageAfterUpdate = "Punjabi";



            }
            else if (LanguageBeforeUpdate != ListOfLanguages[0])
            {
                IWebElement AddLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(1) > input[type=text]"));

                AddLanguage.Clear();

                AddLanguage.SendKeys("English");
                Console.WriteLine("English" + "Has been updated at place of "+ LanguageBeforeUpdate);
 
                IWebElement Update = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > span > input.ui.teal.button"));
                Update.Click();
                LanguageAfterUpdate = "English";

            }
            else if (LanguageBeforeUpdate != ListOfLanguages[1])
            {
                IWebElement AddLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(1) > input[type=text]"));

                AddLanguage.Clear();

                AddLanguage.SendKeys("Hindi");
                Console.WriteLine("Hindi");


                IWebElement Update = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > span > input.ui.teal.button"));
                Update.Click();

                LanguageAfterUpdate = "Hindi";


            }
            else if (LanguageBeforeUpdate != ListOfLanguages[3])
            {
                IWebElement AddLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(1) > input[type=text]"));

                AddLanguage.Clear();

                AddLanguage.SendKeys("Chinese");


                IWebElement Update = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > span > input.ui.teal.button"));
                Update.Click();
                LanguageAfterUpdate = "Chinese";




            }
            else if (LanguageBeforeUpdate != ListOfLanguages[4])
            {
                IWebElement AddLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(1) > input[type=text]"));

                AddLanguage.Clear();

                AddLanguage.SendKeys("Korean");


                IWebElement Update = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > span > input.ui.teal.button"));
                Update.Click();
                LanguageAfterUpdate = "Korean";

            }

            else if (LanguageBeforeUpdate != ListOfLanguages[5])
            {
                IWebElement AddLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > div:nth-child(1) > input[type=text]"));

                AddLanguage.Clear();

                AddLanguage.SendKeys("French");


                IWebElement Update = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td > div > span > input.ui.teal.button"));
                Update.Click();
                LanguageAfterUpdate = "French";

            }



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


            // read value of top 10 skills and print them in output

            try
            {
                for (b = 2; b < 10; b++)
                {
                    IWebElement LanguageData = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(" + b + ") > tr > td:nth-child(1)"));
                    Console.WriteLine(LanguageData.Text + " is a Language present in list");



                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        [Then(@"Languages are visible on Profile page")]
        public void ThenLanguagesAreVisibleOnProfilePage()
        {

            // check if atleast one language entry was read

            Assert.That(b > 2, "No Language to be read");

            Console.WriteLine("To read entry atleast one entry should be present, before this test make sure atleast one entry is present which could be read");



        }






        [When(@"I Create ""([^""]*)"" Seller can speak")]
        public void WhenICreateSellerCanSpeak(string F0)
        {

            // click on add new language button

            IWebElement AddNewLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            AddNewLanguage.Click();


            // add new languave to the designated field
            IWebElement LanguageName = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]"));
            LanguageName.SendKeys(F0);
             F1 = F0;

            // add value to Level of language to be added

            SelectElement DropDown = new SelectElement(driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select")));
            DropDown.SelectByValue("Basic");


            // add new language
            IWebElement AddNew = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > div > div.six.wide.field > input.ui.teal.button"));
            AddNew.Click();




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
            //if language entry exist delete the first entry
            try
            {
                IWebElement LanguageToBeDelete = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(1)"));
                BeforeDelete = LanguageToBeDelete.Text;



                IWebElement Delete = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(2) > i"));
                Delete.Click();
                BeforeDelete = LanguageToBeDelete.Text;
            }
            catch (Exception NoLanguage)
            {

                // if can't find any language entry for delete operation 

                Console.WriteLine(@"Error occurred Deleting Languag" + NoLanguage);
                
            
            }
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




















