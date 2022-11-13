using System;
using System.Collections.Generic;
using System.Text;
using WorkshopBDD.Settings;

namespace WorkshopBDD.Interfaces
{
    public interface IConfig
    {
        public BrowserType GetBrowser();
        public string GetCreditCardNumber();
        public string GetExpirationDate();
        public string GetCvc();
        public string GetWebsite();
    }
}
