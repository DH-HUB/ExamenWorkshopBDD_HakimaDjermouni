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
    public class TextBoxTests
    {
        [TestInitialize]
        public void Init()
        {
            NavigationHelper.NavigateToHomePage();
        }

        [TestMethod]
        public void TextBoxTest()
        {
            IWebElement element = GenericHelper.GetElement(By.Id("creditCardNumber"));
            element.SendKeys(ObjectRepository.Config.GetCreditCardNumber());
            element = GenericHelper.GetElement(By.Id("expirationDate"));
            element.SendKeys(ObjectRepository.Config.GetExpirationDate());
            element = GenericHelper.GetElement(By.Id("cvc"));
            element.SendKeys(ObjectRepository.Config.GetCvc());
        }

        [TestMethod]
        public void TextBoxFromHelperTest()
        {
            TextBoxHelper.TypeInTextBox(By.Id("creditCardNumber"), ObjectRepository.Config.GetCreditCardNumber());
            TextBoxHelper.TypeInTextBox(By.Id("expirationDate"), ObjectRepository.Config.GetExpirationDate());
            TextBoxHelper.TypeInTextBox(By.Id("cvc"), ObjectRepository.Config.GetCvc());
        }

        [TestMethod]
        public void ClearTextBoxTest()
        {
            TextBoxHelper.TypeInTextBox(By.Id("creditCardNumber"), ObjectRepository.Config.GetCreditCardNumber());
            TextBoxHelper.ClearTextBox(By.Id("creditCardNumber"));


        }
    }
}
