using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinitions
{
    [Binding]
    public class AddSkillsStepDefinitions : Driver
    {
        // new add skill object
        Skills addSkillObject = new Skills();

        [Given(@"\[Navigate to Skills page]")]
        public void GivenNavigateToSkillsPage()
        {
        }

        [When(@"\[I add '([^']*)' and '([^']*)' to Skills page]")]
        public void WhenIAddAndToSkillsPage(string Skill, string SkillLevel)
        {
            // Call the function in Skills.cs
            addSkillObject.AddSkills(driver, Skill, SkillLevel);
        }

        [Then(@"\[The '([^']*)' and '([^']*)' has been created successfully]")]
        public void ThenTheAndHasBeenCreatedSuccessfully(string Skill, string SkillLevel)
        {
            string actualSkill = addSkillObject.GetSkill(driver);
            string actualSkillLevel = addSkillObject.GetSkillLevel(driver);

            // Assertion for checking added skills.
            Assert.That(actualSkill != Skill, "Actual Skill and Expected Skill do not match");
            Assert.That(actualSkillLevel != SkillLevel, "Actual SkillLevel and Expected SkillLevel do not match");

        }
    }
}
