using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using WorkshopBDD.CustomExceptions;
using WorkshopBDD.Interfaces;
using WorkshopBDD.Settings;

namespace WorkshopBDD.Configuration
{
    public class ConfigReader : IConfig
    {
        private WorkshopSettings settings;

        public ConfigReader()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(@"C:\Users\HDJERMOUNI\source\repos\repos\WorkshopBDD_FullATDD\WorkshopBDD\WorkshopBDD\appsetings.json")
                .AddEnvironmentVariables()
                .Build();

            settings = config.GetRequiredSection(nameof(WorkshopSettings)).Get<WorkshopSettings>();
        }

        public BrowserType GetBrowser()
        {
            string browser = settings.Browser;

            try
            {
                return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
            }
            catch (ArgumentException)
            {
                throw new NoSuitableDriverFound("Aucun driver n'a été trouvé  : " + settings.Browser);
            }
        }

        public string GetCreditCardNumber()
        {
            return settings.creditCardNumber;
        }

        public string GetExpirationDate()
        {
            return settings.expirationDate;
        }

        public string GetWebsite()
        {
            return settings.Website;
        }
        public string GetCvc()
        {
            return settings.cvc;
        }

        public string CreditCardNumber()
        {
            throw new NotImplementedException();
        }

        public string GetPlayerOne()
        {
            throw new NotImplementedException();
        }

        public string GetPlayerTwo()
        {
            throw new NotImplementedException();
        }
    }
}
