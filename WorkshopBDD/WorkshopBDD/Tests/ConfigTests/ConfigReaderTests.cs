using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WorkshopBDD.BaseClasses;
using WorkshopBDD.Configuration;
using WorkshopBDD.Interfaces;

namespace WorkshopBDD.Tests.ConfigTests
{
    [TestClass]
    public class ConfigReaderTests
    {
        [TestMethod]
        public void GetConfigKeysFromConfigReader()
        {
            IConfig config = new ConfigReader();
            Console.WriteLine("Browser : " + config.GetBrowser());
            Console.WriteLine("CreditCardNumber : " + config.GetCreditCardNumber());
            Console.WriteLine("GetExpirationDate :" + config.GetExpirationDate());
            Console.WriteLine("Cvc :" + config.GetCvc());
            Console.WriteLine("Website : " + config.GetWebsite());
        }

        [TestMethod]
        public void GetConfigKeysFromObjectRepository()
        {
            Console.WriteLine("Browser : " + ObjectRepository.Config.GetBrowser());
            Console.WriteLine("CreditCardNumber : " + ObjectRepository.Config.GetCreditCardNumber());
            Console.WriteLine("ExpirationDate : " + ObjectRepository.Config.GetExpirationDate());
            Console.WriteLine("Cvc : " + ObjectRepository.Config.GetCvc());
            Console.WriteLine("Website : " + ObjectRepository.Config.GetWebsite());
        }
    }
}
