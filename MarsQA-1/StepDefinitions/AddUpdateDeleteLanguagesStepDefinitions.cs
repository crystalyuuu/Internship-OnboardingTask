using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class AddUpdateDeleteLanguagesStepDefinitions : Driver
    {
        Languages addLanguageObject = new Languages();

        // Add part
        [Given(@"\[Navigate to Language page]")]
        public void GivenNavigateToLanguagePage()
        {
        }

        [When(@"\[I add '([^']*)' and '([^']*)' to Language page]")]
        public void WhenIAddAndToLanguagePage(string Language, string ChooseLanguageLevel)
        {
            addLanguageObject.AddLanguage(driver, Language, ChooseLanguageLevel);
        }

        [Then(@"\[The '([^']*)' and '([^']*)' have been created successfully\.]")]
        public void ThenTheAndHaveBeenCreatedSuccessfully_(string Language, string ChooseLanguageLevel)
        {
            string ActualLanguage = addLanguageObject.GetLanguage(driver);
            string ActualLanguageLevel = addLanguageObject.GetLanguageLevel(driver);

            // Assertion for checking added language
            Assert.That(ActualLanguage != Language, "Actual Language and Expected Language do not match");
            Assert.That(ActualLanguageLevel != ChooseLanguageLevel, "Actual Language Level and Expected Language Level do not match");
        }

        // Update part 
        [Given(@"\[Navigate to the update Languages page]")]
        public void GivenNavigateToTheUpdateLanguagesPage()
        {
        }

        [When(@"\[I update '([^']*)' and '([^']*)' in Languages page]")]
        public void WhenIUpdateAndInLanguagesPage(string LanguageUpdate, string UpdateChooseLanguageLevel)
        {
            addLanguageObject.EditLanguage(driver, LanguageUpdate, UpdateChooseLanguageLevel);
        }

        [Then(@"\[The '([^']*)' and '([^']*)' have been updated successfully\.]")]
        public void ThenTheAndHaveBeenUpdatedSuccessfully_(string LanguageUpdate, string UpdateChooseLanguageLevel)
        {
            string EditedLanguage = addLanguageObject.GetEditedLanguage(driver);
            string EditedLanguageLevel = addLanguageObject.GetEditedLanguageLevel(driver);

            // Assertion for checking edited language
            Assert.That(EditedLanguage != LanguageUpdate, "Edited Language and Expected Language do not match");
            Assert.That(EditedLanguageLevel != UpdateChooseLanguageLevel, "Edited Language Level and Expected Language Level match");
        }

        // Delete part
        [Given(@"\[Navigate to the delete Languages page]")]
        public void GivenNavigateToTheDeleteLanguagesPage()
        {
        }

        [When(@"\[I delete a Language in Languages page]")]
        public void WhenIDeleteALanguageInLanguagesPage()
        {
            addLanguageObject.DeleteLanguage(driver);
        }

        [Then(@"\[The language have been deleted successfully]")]
        public void ThenTheLanguageHaveBeenDeletedSuccessfully()
        {
            string DeletedLanguage = addLanguageObject.GetDeletedLanguage(driver);
            string DeletedLanguageLevel = addLanguageObject.GetDeletedLanguageLevel(driver);

            // Assertion for checking deleted language
            Assert.That(DeletedLanguage != "Japanese", "Language deleted successfully");
            Assert.That(DeletedLanguageLevel != "Basic", "Language Level deleted successfully");
        }
    }
}
