using Background.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Background.StepDefinition
{
    [Binding]
    public class BackgroundSteps
    {
        BackgroundPage backgroundPage;

        public BackgroundSteps()
        {
            backgroundPage = new BackgroundPage();
        }


        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            backgroundPage.NavigateToWebsite(url);
        }
        
        [When(@"I enter username text ""(.*)""")]
        public void WhenIEnterUsernameText(string Username)
        {
            backgroundPage.EnterUsername(Username);
        }
        
        [When(@"I enter email text ""(.*)""")]
        public void WhenIEnterEmailText(string Email)
        {
            backgroundPage.EnterEmail(Email);
        }
        
        [When(@"I enter password text ""(.*)""")]
        public void WhenIEnterPasswordText(string PasswordSecured)
        {
            backgroundPage.EnterPassword(PasswordSecured);
        }
        
        [When(@"I click on sign up button")]
        public void WhenIClickOnSignUpButton()
        {
            backgroundPage.ClickSignUpButton();
        }
        
        [When(@"I click on New Article")]
        public void WhenIClickOnNewArticle()
        {
            backgroundPage.ClickOnNewArticle();
        }

        [When(@"I write my Article Title ""(.*)""")]
        public void WhenIWriteMyArticleTitle(string articleTitle)
        {
            backgroundPage.EnterArticleTitle(articleTitle);
        }

        [When(@"I write what my article is all about ""(.*)""")]
        public void WhenIWriteWhatMyArticleIsAllAbout(string article)
        {
            backgroundPage.EnterWhatMyArticleIsAllAbout(article);
        }

        [When(@"I write my Article ""(.*)""")]
        public void WhenIWriteMyArticle(string registration)
        {
            backgroundPage.EnterWriteMyArticle(registration);
        }

        [When(@"I enter tags ""(.*)""")]
        public void WhenIEnterTags(string demo)
        {
            backgroundPage.EnterTags(demo);
        }

        [When(@"I click on publish Article")]
        public void WhenIClickOnPublishArticle()
        {
            backgroundPage.ClickOnPublishArticle();
        }
        
        [When(@"I click on Global Feed")]
        public void WhenIClickOnGlobalFeed()
        {
            backgroundPage.ClickOnGlobalFeed();
        }
        
        [Then(@"my article should be created successfully")]
        public void ThenMyArticleShouldBeCreatedSuccessfully()
        {
            Assert.That(backgroundPage.IsMyArticleDisplayed);
        }
        
        [Then(@"I should be able to see all global feed")]
        public void ThenIShouldBeAbleToSeeAllGlobalFeed()
        {
            Assert.That(backgroundPage.IsAllGlobalFeedDisplayed);
        }
    }
}
