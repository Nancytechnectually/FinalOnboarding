using System;
using System.Collections.Generic;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace MarsQA_1
{
    [Binding]
    public class Feature2SkillsStepDefinitions : Driver
    {
        public int a;
        public String SkillBeforeDelete;
        public String BeforeUpdateSkill;
        public String AfterUpdateSkill;
        string[] ListOfSkills = { "SkillA", "SkillB" };

        ProfilePage ObjectProfile = new ProfilePage();


        [Given(@"I Click on Skills Tab")]
        public void GivenIClickOnSkillsTab()
        {

            // click on skills tab
            IWebElement SkillTab = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)"));
            SkillTab.Click();



        }

        [When(@"I Create a new  Skill ""([^""]*)"" at ""([^""]*)""")]
        public void WhenICreateANewSkillAt(string P0, string P1)
        {
            ObjectProfile.CreateSkill(P0 , P1);
            
        }
        [Then(@"Check New Skill  has been added")]
        public void ThenCheckNewSkillHasBeenAdded()
        {

           string P0 = ObjectProfile.getvariableP0();



            driver.Navigate().Refresh();
            TurnOnWait();

            // check skill has been added 
            try
            {
                
                // click on skills tab
                IWebElement SkillTab = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)"));
                SkillTab.Click();

                String bodyText1 = driver.FindElement(By.TagName("body")).Text;
                Assert.True(bodyText1.Contains(P0), "Text not found!");
                Console.WriteLine(P0 + " was added Successfully");
            }
            catch
            {
                // if addition was not successful

                Console.WriteLine("New skill was not created Successfully");

            }
            
           
               
                Console.WriteLine("As, we cannot add any skill twice make sure skill is not already created  before this operation. In case, the test fails, delete the skill from portal and add again");
 
        }



        [When(@"I check the Skills Seller is offering")]
        public void WhenICheckTheSkillsSellerIsOffering()
        {

            ObjectProfile.ReadSkill();

        
        }

        [Then(@"Skills are visible on Profile page")]
        public void ThenSkillsAreVisibleOnProfilePage()
        {
          int y = ObjectProfile.getVariablea();
            //check atleast one value was read
            Assert.That(y > 2, "Read failed");
            Console.WriteLine("To read value atleast one entry should be present, before this test make sure atleast one entry is present which could be read");



        }



        [When(@"I Delete a skill")]
        public void WhenIDeleteASkill()
        {

            ObjectProfile.DeleteSkill();

        }

        [Then(@"Check Skill has been deleted")]
        public void ThenCheckSkillHasBeenDeleted()
        {

            String SkillBeforeDelete1 = ObjectProfile.getVariableSkillBeforeDelete();


            //check delete operation was successful or not

            if (SkillBeforeDelete1 != "No Skill")

            {

                IWebElement SkillTab = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)"));
                SkillTab.Click();

                String bodyText = driver.FindElement(By.TagName("body")).Text;
                Assert.True(bodyText.Contains(SkillBeforeDelete1), "Language was not Deleted");


            }
            else
            {
                SkillBeforeDelete1 = "No Skill";

            }


            Console.WriteLine("To delete entry atleast one entry should be present, before this test make sure atleast one entry is present which could be deleted");



        }








        [When(@"I Update  Skills Seller is offering")]
        public void WhenIUpdateSkillsSellerIsOffering()
        {

            ObjectProfile.UpdateSkill();

        }

        
    

        [Then(@"Check   Skills has been updated")]
        public void ThenCheckSkillsHasBeenUpdated()
        {


            String BeforeUpdateSkill1 = ObjectProfile.getVariableSkillBeforeUpdate();

            String AfterUpdateSkill1 = ObjectProfile.getVariableSkillAfterUpdate();





            //check if skill has been updated
            Assert.That(AfterUpdateSkill1 != BeforeUpdateSkill1, "Skill was not updated");

            Console.WriteLine(AfterUpdateSkill1 + " has been added at place of " + BeforeUpdateSkill);

            IWebElement DropUpdate = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(2) > select"));
            Console.WriteLine("Level of updated skill is " + DropUpdate.Text);
            Console.WriteLine("To update entry atleast one entry should be present, before this test make sure atleast one entry is present which could be updated");


        }

    }
}
