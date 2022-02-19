using MarsQA_1.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Certifications
    {
        // Select table row for XPath and find the order of certificate
        private static IWebElement certificationsPage => Driver.driver.FindElement(By.XPath(".//*[@class='ui top attached tabular menu']/a[4]"));
        private static IWebElement addNewBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private static IWebElement addCertificateTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
        private static IWebElement addCertificateFromTextBox => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
        private static IWebElement yearDropDown => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
        private static IWebElement addCertificationsBtn => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
        
        // th: table row, select table row for XPath and find the order of certificate
        private static IWebElement actualCertificate => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[1]"));
        private static IWebElement actualCertificateFrom => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[2]"));
        private static IWebElement actualYear => Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[3]"));

        public void AddCertifications(IWebDriver driver, string Certificate, string CertificateFrom, string Year)
        {
            certificationsPage.Click();

            addNewBtn.Click();

            addCertificateTextBox.SendKeys(Certificate);

            addCertificateFromTextBox.SendKeys(CertificateFrom);

            // Dropdown to select different year by using SelectElement
            SelectElement addYear = new SelectElement(yearDropDown);
            addYear.SelectByValue(Year);

            addCertificationsBtn.Click();

        }
        public string GetCertificate(IWebDriver driver)
        {
            return actualCertificate.Text;
        }
        public string GetCertificateFrom(IWebDriver driver)
        {
            return actualCertificateFrom.Text;
        }
        public string GetYear(IWebDriver driver)
        {
            return actualYear.Text;
        }
    }
}