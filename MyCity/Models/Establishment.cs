using System;
using System.Collections.Generic;
using System.Text;
using MyCity.Resources.Enums;

namespace MyCity.Models
{
    public class Establishment
    {
        public int IdEstablishment { get; set; }
        public EstablishmentType TypeEstablishment { get; set; }
        public string NameEstablishment { get; set; }
        public string LogoEstablishment { get; set; }
        public string DescriptionEstablishment { get; set; }
        public string AddressEstablishment { get; set; }
        public string PhoneEstablishment { get; set; }
        public double ReviewsEstablishment { get; set; }
    }
}
