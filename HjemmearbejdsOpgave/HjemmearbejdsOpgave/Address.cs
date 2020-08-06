using System;
using System.Collections.Generic;
using System.Text;

namespace HjemmearbejdsOpgave
{
    public class Address
    {
        string street;
        string city;
        string postalCode;
        string country;

        public Address(string street, string city, string postalCode, string country)
        {
            this.street = street;
            this.city = city;
            this.postalCode = postalCode;
            this.country = country;
        }

        public string ReturnAddress() // retunere hele ens addresse
        {
            return $"{street}\n{city}\n{postalCode}\n{country}";
        }
    }
}
