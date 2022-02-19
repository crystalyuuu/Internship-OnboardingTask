using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Skills
    {
        // Select table row and find XPath for skills.
        private static IWebElement skilPage => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
        private static IWebElement addBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
        private static IWebElement addSkillTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[1]/input"));
        private static IWebElement skillLevelDropdown => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select"));
        private static IWebElement addSkillBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
        // Select table row and find XPath for added skill and skill level.
        private static IWebElement actualSkill => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[1]"));
        private static IWebElement actualSkillLevel => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[2]"));

        internal void AddSkills(IWebDriver driver, string Skill, string SkillLevel)
        {
            // Steps in adding new skills
            skilPage.Click();

            addBtn.Click();
            addSkillTextBox.SendKeys(Skill);

            // Dropdown button to select option by using select element.
            SelectElement addSkill = new SelectElement(skillLevelDropdown);
            addSkill.SelectByValue(SkillLevel);

            addSkillBtn.Click();
        }
        public string GetSkill(IWebDriver driver)
        {
            return actualSkill.Text;
        }
        public string GetSkillLevel(IWebDriver driver)
        {
            return actualSkillLevel.Text;
        }

    }
}
