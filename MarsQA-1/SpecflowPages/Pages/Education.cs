using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Education
    {
        // Select table row to get XPath, find the order of education.
        private static IWebElement educationPage => Driver.driver.FindElement(By.XPath(".//*[@class='ui top attached tabular menu']/a[3]"));
        private static IWebElement addBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div"));
        private static IWebElement universityTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[1]/input"));
        private static IWebElement countryDropDown => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[1]/div[2]/select"));
        private static IWebElement titleDropDown => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[1]/select"));
        private static IWebElement degreeTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[2]/input"));
        private static IWebElement yearDropDown => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[2]/div[3]/select"));
        private static IWebElement addEducationBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
        
        // Select table row to get XPath, find the order for country, university, title, degree and year.
        private static IWebElement actualCountry => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[1]"));
        private static IWebElement actualUniversity => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[2]"));
        private static IWebElement actualTitle => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[3]"));
        private static IWebElement actualDegree => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[4]"));
        private static IWebElement actualYear => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[5]"));


    internal void AddEducation(IWebDriver driver, string Country, string University, string Title, string Degree, string Year)
        {
            // Steps of adding new education 
            educationPage.Click();
            addBtn.Click();

            // Dropdown to select different country by using SelectElement.
            SelectElement addcountryname = new SelectElement(countryDropDown);
            addcountryname.SelectByValue(Country);

            universityTextBox.SendKeys(University);

            // Dropdown to select different title by using SelectElement.
            SelectElement addtitlename = new SelectElement(titleDropDown);
            addtitlename.SelectByValue(Title);

            degreeTextBox.SendKeys(Degree);

            // Dropdown to select different year by using SelectElement.
            SelectElement addyearname = new SelectElement(yearDropDown);
            addyearname.SelectByValue(Year);

            addEducationBtn.Click();
        }


        public string GetCountry(IWebDriver driver)
        {
            return actualCountry.Text;
        }
        public string GetUniversity(IWebDriver driver)
        {
            return actualUniversity.Text;
        }
        public string GetTitle(IWebDriver driver)
        {
            return actualTitle.Text;
        }
        public string GetDegree(IWebDriver driver)
        {
            return actualDegree.Text;
        }
        public string GetYear(IWebDriver driver)
        {
            return actualYear.Text;
        }


    }
}
