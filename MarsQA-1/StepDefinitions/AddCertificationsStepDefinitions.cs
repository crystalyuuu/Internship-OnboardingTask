using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class AddCertificationsStepDefinitions : Driver
    {
        // New a object name addCertificationObject
        Certifications addCertificationObject = new Certifications();

        [Given(@"\[Navigate to Certifications page]")]
        public void GivenNavigateToCertificationsPage()
        {
        }

        [When(@"\[I add '([^']*)' and '([^']*)' and '([^']*)' to Certifications page]")]
        public void WhenIAddAndAndToCertificationsPage(string Certificate, string CertificateFrom, string Year)
        {
            // Call the function in Certification.cs
            addCertificationObject.AddCertifications(driver, Certificate, CertificateFrom, Year);
        }

        [Then(@"\[The '([^']*)' and '([^']*)' and '([^']*)' have been created successfully\.]")]
        public void ThenTheAndAndHaveBeenCreatedSuccessfully_(string Certificate, string CertificateFrom, string Year)
        {
            // Call the function in Certification.cs
            string actualCertificate = addCertificationObject.GetCertificate(driver);
            string actualCertificateFrom = addCertificationObject.GetCertificateFrom(driver);
            string actualYear = addCertificationObject.GetYear(driver);

            // Assertion for checking added Certification to Profile
            Assert.That(actualCertificate != Certificate, "Actual certificate and Expected certificate do not match");
            Assert.That(actualCertificateFrom != CertificateFrom, "Actual company and Expected company do not match");
            Assert.That(actualYear != Year, "Actual year and expected year do not match");
        }
    }
}
