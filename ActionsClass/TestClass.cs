// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

/// <summary>
/// Performed all Actions class methods step by step
/// Just keep in mind that dont run all test cases at a time.
/// </summary>
namespace ActionsClass
{
    [TestFixture]
    public class TestClass
    {
        // Declared globally IWebdriver 
        public IWebDriver driver; 

        [Test]
        public void ActionsMoveToElementMethod()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver.Navigate().GoToUrl("http://www.uitestpractice.com/Students/Actions");
            driver.Url = "http://www.uitestpractice.com/Students/Actions";
            // Object of Actions class
            Actions actions = new Actions(driver);

            // 1.actions.MoveToElement(driver.FindElement(By.Id("div2")))
            // 2.actions.MoveToElement(driver.FindElement(By.Id("div2")), 20, 20)
            // 3.actions.MoveToElement(driver.FindElement(By.Id("div2")), 20, 20,MoveToElementOffsetOrigin.TopLeft)
            // 4.
            actions.MoveToElement(driver.FindElement(By.Id("div2")), 20, 20, MoveToElementOffsetOrigin.Center)
           .ContextClick()
                .Build()
                .Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void ActionsClickMethod()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);

            //Click method without parameter
            //actions.MoveToElement(driver.FindElement(By.Name("click")))
            // .Click()
            // .Build()
            // .Perform();

            //Click method with parameter(IWebElement onElement0
            actions.Click(driver.FindElement(By.Name("click")))
           .Build()
           .Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void doubleClickMethod()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);

            // actions.MoveToElement(driver.FindElement(By.Name("dblClick")))
            //.DoubleClick()
            //.Build()
            //.Perform();
            actions.DoubleClick(driver.FindElement(By.Name("dblClick")))
            .Build()
            .Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void ActionsClickAndHoldAndRelease()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);
            //// Both ClickAndHold and release without parameters
            //actions.MoveToElement(driver.FindElement(By.Name("one")))
            //    .ClickAndHold()
            //    .MoveToElement(driver.FindElement(By.Name("twelve")))
            //    .Release()
            //// ClickAndHold with paramter and release without parameters
            //actions.ClickAndHold(driver.FindElement(By.Name("one")))
            //    .MoveToElement(driver.FindElement(By.Name("twelve")))
            //    .Release()
            // Both ClickAndHold and release  with paramter
            actions.ClickAndHold(driver.FindElement(By.Name("one")))
                .Release(driver.FindElement(By.Name("twelve")))
                .Build()
                .Perform();
                Thread.Sleep(2000);
                driver.Quit();
        }

        [Test]
        public void ActionsContextClick()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);

            //// ContextClick without parameters
            //actions.MoveToElement(driver.FindElement(By.Name("one")))
            //    .ContextClick()

            // ContextClick with paramter
            actions.ContextClick(driver.FindElement(By.Name("one")))
                .Build()
                .Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void ActionsMoveByOffset()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);

            // MoveByOffset with paramter
            actions.MoveByOffset(200,200)
                .ContextClick()
                .Build()
                .Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void ActionsDragAndDrop()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);

            actions.DragAndDrop(driver.FindElement(By.Id("draggable")), driver.FindElement(By.Id("droppable")))
                .Build()
                .Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void ActionsDragAndDropOffset()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);

            actions.DragAndDropToOffset(driver.FindElement(By.Id("draggable")), 150,20)
                .Build()
                .Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void ActionsKeyDownKeyUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);

            //actions.KeyDown(Keys.Control)
            //    .Click(driver.FindElement(By.Name("one")))
            //    .Click(driver.FindElement(By.Name("six")))
            //    .Click(driver.FindElement(By.Name("eleven")))
            //    .KeyUp(Keys.Control)

            actions.KeyDown(driver.FindElement(By.Name("one")),Keys.Control)
            .KeyDown(driver.FindElement(By.Name("six")),Keys.Control)
            .KeyUp(driver.FindElement(By.Name("eleven")),Keys.Control)
            .Build()
            .Perform();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void ActionsSendkeys()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.uitestpractice.com/Students/Actions";
            Actions actions = new Actions(driver);
            // Scroll the page down and the page up
            actions.SendKeys(Keys.End)
                .Perform();
            Thread.Sleep(2000);

            actions.SendKeys(Keys.Home)
                .Perform();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void ActionsSendkeysFillForm()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.ankpro.com/Account/Register";
            Actions actions = new Actions(driver);
            actions.Click(driver.FindElement(By.Id("Email")))
            .SendKeys("x@x.com" + Keys.Tab)
            .SendKeys("password123" + Keys.Tab)
            .SendKeys("password123" + Keys.Tab)
            .Build()
            .Perform();

            Thread.Sleep(2000);
            driver.Quit();
        }

        [Test]
        public void ClearTextBoxWithoutClear()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://www.ankpro.com/Account/Register";
            Actions actions = new Actions(driver);
            driver.FindElement(By.Id("Email")).SendKeys("a@a.com");
            Thread.Sleep(2000);
            actions.Click(driver.FindElement(By.Id("Email")))
                .KeyDown(Keys.Control)
                //To select all content in text field
                .SendKeys("a")
                .KeyUp(Keys.Control)
                .SendKeys(Keys.Backspace)
            .Build()
            .Perform();

            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
