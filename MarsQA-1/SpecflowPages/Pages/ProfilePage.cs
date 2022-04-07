using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQA_1.SpecflowPages.Pages
{
    public  class ProfilePage : Driver
    {
        // Variables Defined 
        public String LanguageBeforeUpdate;
        public String LevelBeforeUpdate;
        public string LanguageAfterUpdate;
        public string afterDelete;
        public string F1;
        public String BeforeDelete = "No Language";
        string[] ListOfLanguages = { "English", "Hindi", "Punjabi", "Chinese", "Korean", "French" };
         public int b = 2;
        public int a;
        public String SkillBeforeDelete;
        public String BeforeUpdateSkill;
        public String AfterUpdateSkill;
       public string[] ListOfSkills = { "SkillA", "SkillB" };

        public String VariableP0;
        public void CreateDescription()
        {
            // To click on add description icon 

            Wait.ClickableElement(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span", 10);

            IWebElement addDescription = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span"));
            addDescription.Click();



            // To add description we need to clear any previous description first
            IWebElement description = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > div.field > textarea"));
            description.Clear();
           
            description.SendKeys("It is a new dummy Description");

            //Save the added description

            IWebElement saveDescription = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > button"));
            saveDescription.Click();


        }

        public void Updatedescription ()

        {

            //To add description click on edit description icon
            Wait.ClickableElement(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span", 10);

            IWebElement addDescription = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > h3 > span"));
            addDescription.Click();



            // Update description in the field
            IWebElement description = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > div.field > textarea"));
            description.Clear();


            description.SendKeys("It is an updated Description");

            // Save the addded description
            IWebElement saveDescription = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > form > div > div > div.ui.twelve.wide.column > button"));
            saveDescription.Click();



        }
        public void CheckDescription ()

        {

            // Wait for Description to appear on page
            //Wait.ElementVisible(driver, "CssSelector", "#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > span", 10);
            Thread.Sleep(2000);
            IWebElement check = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > div > div > div > span"));


            //Print Description

            Console.WriteLine(check.Text);



        }






        public void CreateLanguage(String F0)

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
        public void CheckLanguage()

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
        public int getVariableb()
        {
            return b;
        }
        public void UpdateLanguage()

        {
            // Read and save value of Language to be updated in a variable 

            IWebElement CheckLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(1)"));
            LanguageBeforeUpdate = CheckLanguage.Text;

            // Read and save value of Level of language to be updated in a variable 

            IWebElement Level = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td:nth-child(2)"));
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
                Console.WriteLine("English" + "Has been updated at place of " + LanguageBeforeUpdate);

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

        public void Deletelanguage ()

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





        public void CreateSkill(String P0 , String P1)

        {

            String bodyText = driver.FindElement(By.TagName("body")).Text;

            if (bodyText.Contains(P0))

            {
                VariableP0 = "SkillAlreadyadded";

            }
            else
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

                VariableP0 = P0;
            }


        }


        public String getvariableP0()
        {
            return VariableP0;
        }




        public void ReadSkill()

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

        public int getVariablea()
        {
            return a;
        }


        public void UpdateSkill()

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

        public void DeleteSkill()

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

        public String getVariableSkillBeforeDelete()
        {
            return SkillBeforeDelete;
        }


        public String getVariableSkillBeforeUpdate()
        {
            return BeforeUpdateSkill;
        }
        public String getVariableSkillAfterUpdate()
        {
            return AfterUpdateSkill;
        }




    }
}
