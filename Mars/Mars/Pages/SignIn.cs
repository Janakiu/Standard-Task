﻿using Mars.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars.Pages
{
    class SignIn
    {
        internal void LoginSteps()
        {
            //Populate the excel data
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");

            //Navigate to the SkillSwapPro Website
            GlobalDefinitions.driver.Navigate().GoToUrl(GlobalDefinitions.ExcelLib.ReadData(2, "Url"));
            GlobalDefinitions.driver.Navigate().GoToUrl("http://localhost:5000/Home");

            //Click on Sign In Tab
            IWebElement SignIntab = GlobalDefinitions.driver.FindElement(By.XPath("//a[contains(text(),'Sign')]"));
            SignIntab.Click();

            //Giving value for Email field
            IWebElement Email = GlobalDefinitions.driver.FindElement(By.Name("email"));
            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Username"));

            //Giving value for Password field
            IWebElement Password = GlobalDefinitions.driver.FindElement(By.Name("password"));
            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            //Clicking on Login Button
            IWebElement LoginBtn = GlobalDefinitions.driver.FindElement(By.XPath("//button[contains(text(),'Login')]"));
            LoginBtn.Click();
        }

    }
}
