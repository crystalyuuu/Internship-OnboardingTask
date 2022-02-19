using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class AddEducationStepDefinitions : Driver
    {
        // new add education object
        Education addEducationObject = new Education();

        [Given(@"\[Navigate to Education page]")]
        public void GivenNavigateToEducationPage()
        {
        }

        [When(@"\[I add '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' to Education page]")]
        public void WhenIAddAndAndAndAndToEducationPage(string Country, string University, string Title, string Degree, string Year)
        {
            // Call the function in Eduction.cs, put the parameter in.
            addEducationObject.AddEducation(driver, Country, University, Title, Degree, Year);
        }

        [Then(@"\[The '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' and '([^']*)' have been created successfully\.]")]
        public void ThenTheAndAndAndAndHaveBeenCreatedSuccessfully_(string Country, string University, string Title, string Degree, string Year)
        {
            // Call the function in Eduction.cs
            string actualCountry = addEducationObject.GetCountry(driver);
            string actualUniversity = addEducationObject.GetUniversity(driver);
            string actualTitle = addEducationObject.GetTitle(driver);
            string actualDegree = addEducationObject.GetDegree(driver);
            string actualYear = addEducationObject.GetYear(driver);

            // Assertion for chekcing added education
            Assert.That(actualCountry != Country, "Actual Country and Expected Country do not match");
            Assert.That(actualUniversity != University, "Actual University and Expected University do not match");
            Assert.That(actualTitle != Title, "Actual Title and Expected Title do not match");
            Assert.That(actualDegree != Degree, "Actual Degree and Expected Degree do not match");
            Assert.That(actualYear != Year, "Actual Year and Expected Year do not match");
        }
    }
}
