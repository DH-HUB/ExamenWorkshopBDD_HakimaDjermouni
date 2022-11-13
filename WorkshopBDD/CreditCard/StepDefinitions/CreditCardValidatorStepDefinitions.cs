using FluentAssertions.Common;
using FluentAssertions.Formatting;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using TechTalk.SpecFlow;
using WorkshopBDD.BaseClasses;
using WorkshopBDD.ComponentHelper;
using Assert = NUnit.Framework.Assert;

namespace CreditCard.StepDefinitions
{
    [Binding]

    public class CreditCardValidatorStepDefinitions

    {


        [Given(@"user fills the three inputs")]
        public void GivenUserFillsTheThreeInputs()
        {
           
            TextBoxHelper.TypeInTextBox(By.Id("creditCardNumber"), "1111111111111111");
            TextBoxHelper.TypeInTextBox(By.Id("expirationDate"), "12/2022");
            TextBoxHelper.TypeInTextBox(By.Id("cvc"), "669");
        }

        [Given(@"credit card number is sixteen digits long")]
        public void GivenCreditCardNumberIsSixteenDigitsLong()

        {
            Assert.IsTrue(GenericHelper.GetElement(By.Id("creditCardNumber")).GetAttribute("value").Length == 16);
           
        }


        [Given(@"expiration date is at format MM/YYYY")]

        public void GivenExpirationDateIsAtFormatMMYYYY()
        {
            Assert.IsTrue(Regex.IsMatch(GenericHelper.GetElement(By.Id("expirationDate")).GetAttribute("value"), "[0-9][0-9]/[0-9][0-9][0-9][0-9]"));
            
        }

        [Given(@"cvc is three digits long")]
        public void GivenCvcIsThreeDigitsLong()
        {
           Assert.IsTrue(GenericHelper.GetElement(By.Id("cvc")).GetAttribute("value").Length == 3);

        }

        [When(@"submit button is pressed")]
        public void WhenSubmitButtonIsPressed()
        {
            ButtonHelper.ClickButton(By.Id("submitCard"));
        }

        [Then(@"user is on page paymentConfirmed")]
        public void ThenUserIsOnPagePaymentConfirmed()
        {
           Assert.AreEqual(ObjectRepository.Driver.Url, "http://localhost/paymentConfirmed");
        }

        [Given(@"credit card number is not sixteen digits long")]
        public void GivenCreditCardNumberIsNotSixteenDigitsLong()
        {
            Assert.IsTrue(GenericHelper.GetElement(By.Id("creditCardNumber")).GetAttribute("value").Length != 16);
        }

        [Then(@"user is on homePage")]
        public void ThenUserIsOnHomePage()
        {
            Assert.AreEqual(ObjectRepository.Driver.Url, "http://localhost/Workshop");
        }

        [Given(@"expiration date is not at format MM/YYYY")]
        public void GivenExpirationDateIsNotAtFormatMMYYYY()
        {
            Assert.IsFalse(Regex.IsMatch(GenericHelper.GetElement(By.Id("expirationDate")).GetAttribute("value"), "[0-9][0-9]/[0-9][0-9][0-9][0-9]"));
        }

        [Given(@"cvc is not three digits long")]
        public void GivenCvcIsNotThreeDigitsLong()
        {
            Assert.IsFalse(GenericHelper.GetElement(By.Id("cvc")).GetAttribute("value").Length != 3);
        }
    }
}
