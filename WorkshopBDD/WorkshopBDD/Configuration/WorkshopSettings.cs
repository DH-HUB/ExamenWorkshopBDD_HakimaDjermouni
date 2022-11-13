using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopBDD.Configuration
{
    public class WorkshopSettings
    {
        public string Browser { get; set; }
        public string creditCardNumber { get; set; }
        public string expirationDate { get; set; }
        public string cvc { get; set; }
        public string Website { get; set; }

        public WorkshopSettings(string browser, string creditCardNumber, string expirationDate, string cvc, string website)
        {
            Browser = browser;
            this.creditCardNumber = creditCardNumber;
            this.expirationDate = expirationDate;
            this.cvc = cvc;
            Website = website;
        }
    }
}
