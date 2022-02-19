using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Languages
    {
        private static IWebElement languagePage => Driver.driver.FindElement(By.XPath(".//*[@class='ui top attached tabular menu']/a[1]"));
        private static IWebElement addNewLanguageBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement addLanguageTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input"));
        private static IWebElement languageLevelDropdown => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select"));
        private static IWebElement addBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
        
        private static IWebElement actualLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[1]"));
        private static IWebElement actualLanguageLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[2]"));
        
        // Edit and Update
        private static IWebElement editLanguageBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[1]"));
        private static IWebElement editLanguageTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/div[1]/input"));
        private static IWebElement editLanguageLevelDropdown => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select"));
        private static IWebElement updateLanguageBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td/div/span/input[1]"));

        private static IWebElement editedLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead[1]/tr/th[1]"));
        private static IWebElement editedLanguageLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead[1]/tr/th[2]"));


        // Delete
        private static IWebElement deleteLanguageBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody[1]/tr/td[3]/span[2]"));

        private static IWebElement deletedLanguage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead[1]/tr/th[1]"));
        private static IWebElement deletedLanguageLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead[1]/tr/th[2]"));


        internal void AddLanguage(IWebDriver driver, string Language, string ChooseLanguageLevel)
        {
            languagePage.Click();
            
            addNewLanguageBtn.Click();
            addLanguageTextBox.SendKeys(Language);

            // Select different language level in dropdown by using SelectElement
            SelectElement addnewlanguage = new SelectElement(languageLevelDropdown);
            addnewlanguage.SelectByValue(ChooseLanguageLevel);

            addBtn.Click();

        }
        public string GetLanguage(IWebDriver driver)
        {
            return actualLanguage.Text;
        }
        public string GetLanguageLevel(IWebDriver driver)
        {
            return actualLanguageLevel.Text;
        }

        internal void EditLanguage(IWebDriver driver, string LanguageUpdate, string UpdateChooseLanguageLevel)
        {
            languagePage.Click();
            
            editLanguageBtn.Click();
            editLanguageTextBox.Clear();
            editLanguageTextBox.SendKeys(LanguageUpdate);

            // Re-select different language level in dropdown by using SelectElement
            SelectElement editnewlanguage = new SelectElement(editLanguageLevelDropdown);
            editnewlanguage.SelectByValue(UpdateChooseLanguageLevel);

            updateLanguageBtn.Click();

        }
        public string GetEditedLanguage(IWebDriver driver)
        {
            return editedLanguage.Text;
        }
        public string GetEditedLanguageLevel(IWebDriver driver)
        {
            return editedLanguageLevel.Text;
        }
        internal void DeleteLanguage(IWebDriver driver)
        {
            languagePage.Click();
            
            deleteLanguageBtn.Click();
        }
        public string GetDeletedLanguage(IWebDriver driver)
        {
            return deletedLanguage.Text;
        }
        public string GetDeletedLanguageLevel(IWebDriver driver)
        {
            return deletedLanguageLevel.Text;
        }

    }
}
