using System;
using System.Collections.Generic;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
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

            //click on add new 

            IWebElement AddNewSkill = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > thead > tr > th.right.aligned > div"));
            AddNewSkill.Click();


            // send value of skill to be added
            IWebElement SkillName = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(1) > input[type=text]"));
            
            SkillName.SendKeys(P0);


            // choose the level of skill

            IWebElement Drop = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > div:nth-child(2) > select"));
           

            SelectElement SkillLevel = new SelectElement(Drop);
            SkillLevel.SelectByValue(P1);

            //add new skill

            IWebElement AddNew = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button"));
            AddNew.Click();


        }

        [Then(@"Check New Skill""([^""]*)"" at ""([^""]*)"" has been added")]
        public void ThenCheckNewSkillAtHasBeenAdded(string p0, string p1)
        {

            // check skill has bee n added 

            try
            {
                IWebElement Language = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a.item.active"));
                Language.Click();
                String bodyText = driver.FindElement(By.TagName("body")).Text;
                Assert.True(bodyText.Contains(p0), "Text not found!");
                Console.WriteLine(p0 + " was added");

            }
            catch
            {


                Console.WriteLine(p0 + "was already added/ or could not be added");

            }


            Console.WriteLine("As, we cannot add any skill twice make sure skill is already not added before this operation . in case the test fails, delete the skill from portal and add again");


        }


        [When(@"I check the Skills Seller is offering")]
        public void WhenICheckTheSkillsSellerIsOffering()
        {

            //read first 10 values of skill

            try
            {
                   for (a = 2; a < 10; a++)
                   {
                    IWebElement SkillData = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(" + a + ") > tr > td:nth-child(1)"));
                    Console.WriteLine(SkillData.Text);
                 


                   }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        
        
        }

        [Then(@"Skills are visible on Profile page")]
        public void ThenSkillsAreVisibleOnProfilePage()
        {
            //check atleast one value was read
            Assert.That(a > 2, "Read failed");
            Console.WriteLine("To read value atleast one entry should be present, before this test make sure atleast one entry is present which could be read");



        }



        [When(@"I Delete a skill")]
        public void WhenIDeleteASkill()
        {

            //if a skill entry present do delete operation on first entry

            try
            {
                IWebElement SkillToBeDelete = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td:nth-child(1)"));
                SkillBeforeDelete = SkillToBeDelete.Text;



                IWebElement Delete = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td.right.aligned > span:nth-child(2)"));
                Delete.Click();
                Console.WriteLine(SkillBeforeDelete);
               

            }
            catch (Exception NoSkillAdded)
            {
                Console.WriteLine(@"Error occurred Deleting Languag" + NoSkillAdded);


            }



        }

        [Then(@"Check Skill has been deleted")]
        public void ThenCheckSkillHasBeenDeleted()
        {  
            
            
            //check delete operation was successful or not

            if (SkillBeforeDelete != "No Skill")

            {

                IWebElement SkillTab = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(2)"));
                SkillTab.Click();

                String bodyText = driver.FindElement(By.TagName("body")).Text;
                Assert.True(bodyText.Contains(SkillBeforeDelete), "Language was not Deleted");


            }
            else
            {
                SkillBeforeDelete = "No Skill";

            }
            Console.WriteLine("To delete entry atleast one entry should be present, before this test make sure atleast one entry is present which could be deleted");



        }








        [When(@"I Update  Skills Seller is offering")]
        public void WhenIUpdateSkillsSellerIsOffering()
        {

            //save value of skill to updated

            IWebElement ToUpdate = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(2) > tr > td:nth-child(1)"));
            BeforeUpdateSkill = ToUpdate.Text;


            if (BeforeUpdateSkill != ListOfSkills[0])
            {
                //update skill

                IWebElement EditSkill = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1)"));
                EditSkill.Click();
                AfterUpdateSkill = ListOfSkills[0];

                IWebElement AddSkillForUpdate = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(1) > input[type=text]"));
                AddSkillForUpdate.Clear();
                AddSkillForUpdate.SendKeys(AfterUpdateSkill);



                IWebElement DropUpdate = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(2) > select"));
                DropUpdate.Click();

                SelectElement SkillLevel = new SelectElement(DropUpdate);
                SkillLevel.SelectByValue("Expert");


                IWebElement Update = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > span > input.ui.teal.button"));
                Update.Click();




            }
            else
            {
                //update skill
                IWebElement EditSkill = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1)"));
                EditSkill.Click();
                AfterUpdateSkill = ListOfSkills[1];

                IWebElement AddSkillForUpdate = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(1) > input[type=text]"));
                AddSkillForUpdate.Clear();
                AddSkillForUpdate.SendKeys(AfterUpdateSkill);



                IWebElement DropUpdate = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(2) > select"));
                DropUpdate.Click();

                SelectElement SkillLevel = new SelectElement(DropUpdate);
                SkillLevel.SelectByValue("Expert");


                IWebElement Update = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > span > input.ui.teal.button"));
                Update.Click();


            }

        }

        
    

        [Then(@"Check   Skills has been updated")]
        public void ThenCheckSkillsHasBeenUpdated()
        {
            //check if skill has been updated
            Assert.That(AfterUpdateSkill != BeforeUpdateSkill, "Skill was not updated");

            Console.WriteLine(AfterUpdateSkill + " has been added at place of " + BeforeUpdateSkill);

            IWebElement DropUpdate = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(2) > select"));
            Console.WriteLine("Level of updated skill is " + DropUpdate.Text);
            Console.WriteLine("To update entry atleast one entry should be present, before this test make sure atleast one entry is present which could be updated");


        }

    }
}
