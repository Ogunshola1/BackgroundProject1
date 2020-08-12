using Background.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Background.PageObject
{
    class BackgroundPage
    {
        public BackgroundPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement usernameInput => driver.FindElement(By.XPath("//Input[@placeholder = 'Username']"));

        IWebElement emailInput => driver.FindElement(By.XPath("//Input[@placeholder = 'Email']"));

        IWebElement passwordInput => driver.FindElement(By.XPath("//Input[@placeholder = 'Password']"));

        IWebElement signUpButton => driver.FindElement(By.XPath("//button[text()='Sign up']"));

        IWebElement newArticle => driver.FindElement(By.XPath("(//li[@class='nav-item'])[5]"));

        IWebElement articleTitle => driver.FindElement(By.XPath("//input[@placeholder='Article Title']"));

        IWebElement aboutArticle => driver.FindElement(By.XPath("//input[@ng-model='$ctrl.article.description']"));

        IWebElement writeMyArticle => driver.FindElement(By.XPath("//textarea[@placeholder='Write your article (in markdown)']"));

        IWebElement enterTags => driver.FindElement(By.XPath("//input[@placeholder='Enter tags']"));

        IWebElement publishArticle => driver.FindElement(By.XPath("//button[@ng-click='$ctrl.submit()']"));

        IWebElement globalFeed => driver.FindElement(By.XPath("//a[@class='nav-link']"));

        IWebElement myArticle => driver.FindElement(By.XPath("//a[@class='nav-link active']"));

        IWebElement allGlobalFeed => driver.FindElement(By.XPath("//div[@class='article-preview']"));







        public void EnterUsername(string Username)
        {
            Random randomGenerator = new Random();
            int randomint = randomGenerator.Next(1000);
            usernameInput.SendKeys(Username + randomint);
            //usernameInput.SendKeys("Username");
        }

        public void EnterEmail(string Email)
        {
            Random randomGenerator = new Random();
            int randomint = randomGenerator.Next(1000);
            emailInput.SendKeys(Email + randomint + "@talktalk.net");
            //emailInput.SendKeys("Email");
        }

        public void EnterPassword(string Password)
        {
            passwordInput.SendKeys("Password");
        }

        public void ClickSignUpButton()
        {
            signUpButton.Click();
        }

        public void ClickOnNewArticle()
        {
            Thread.Sleep(5000);
            newArticle.Click();
        }

        public void EnterArticleTitle(string ArticleTitle)
        {
            Thread.Sleep(5000);
            articleTitle.SendKeys(ArticleTitle);
        }

        public void EnterWhatMyArticleIsAllAbout(string AboutArticle)
        {
            Thread.Sleep(5000);
            aboutArticle.SendKeys(AboutArticle);
        }

        public void EnterWriteMyArticle(string Registration)
        {
            writeMyArticle.SendKeys(Registration);
        }

        public void EnterTags(string Demo)
        {
            enterTags.SendKeys(Demo);
        }

        public void ClickOnPublishArticle()
        {
            publishArticle.Click();
        }

        public void ClickOnGlobalFeed()
        {
            globalFeed.Click();
        }

        public bool IsMyArticleDisplayed()
        {
            return myArticle.Displayed;
        }

        public bool IsAllGlobalFeedDisplayed()
        {
            return allGlobalFeed.Displayed;
        }


        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
