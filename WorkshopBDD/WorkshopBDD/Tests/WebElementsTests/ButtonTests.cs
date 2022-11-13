using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using WorkshopBDD.BaseClasses;
using WorkshopBDD.ComponentHelper;

namespace WorkshopBDD.Tests.WebElementsTests
{
    [TestClass]
    public class ButtonTests
    {
        [TestInitialize]
        public void Init()
        {
            NavigationHelper.NavigateToHomePage();
            TextBoxHelper.TypeInTextBox(By.Id("creditCardNumber"), ObjectRepository.Config.GetCreditCardNumber());
            TextBoxHelper.TypeInTextBox(By.Id("expirationDate"), ObjectRepository.Config.GetExpirationDate());
            TextBoxHelper.TypeInTextBox(By.Id("cvc"), ObjectRepository.Config.GetCvc());
        }

        [TestMethod]
        public void IsButtonEnabledTest()
        {
            ButtonHelper.IsButtonEnabled(By.Id("submitCard"));
        }

        [TestMethod]
        public void GetButtonTextTest()
        {
            ButtonHelper.IsButtonEnabled(By.Id("submitCard"));
            Console.WriteLine(ButtonHelper.GetButtonText(By.Id("submitCard")));
        }


        [TestMethod]
        public void ClickOnPlayFromButtonHelperTest()
        {
            ButtonHelper.ClickButton(By.Id("submitCard"));
            Assert.AreEqual(PageHelper.GetPageTitle(), "Payment confirmed");
        }
    }
}
