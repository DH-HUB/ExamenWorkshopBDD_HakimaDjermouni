using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WorkshopBDD.Configuration;

namespace WorkshopBDD.Tests.ConfigTests
{
    [TestClass]
    public class SettingsTests
    {
        private WorkshopSettings settings;

        [TestInitialize]
        public void Init()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("C:\\Users\\HDJERMOUNI\\source\\repos\\repos\\WorkshopBDD_FullATDD\\WorkshopBDD\\WorkshopBDD\\appsetings.json")
                .AddEnvironmentVariables()
                .Build();

            settings = config.GetRequiredSection(nameof(WorkshopSettings)).Get<WorkshopSettings>();
        }

        [TestMethod]
        public void GetCreditCardNumberFromConfig()
        {
            Console.WriteLine($"PlayerOne = {settings.creditCardNumber}");
        }

        [TestMethod]
        public void GetExpirationDateFromConfig()
        {
            Console.WriteLine($"PlayerTwo = {settings.expirationDate}");
        }

        [TestMethod]
        public void GetWebsiteFromConfig()
        {
            Console.WriteLine($"Website = {settings.Website}");
        }

        [TestMethod]
        public void GetCvcFromConfig()
        {
            Console.WriteLine($"Cvc = {settings.cvc}");
        }

    }
}


