using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emigrace.Models
{
    public class PersonViewModel
    {
        public string Name { get; set; }

        public string FamilyName { get; set; }

        public string FatherName { get; set; }

        public string Sex { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Citizenship { get; set; }

        public string PlaceOfBirth { get; set; }

        public string PlaceOfEmigration { get; set; }

        public string PlaceOfLiving { get; set; }

        public string Father { get; set; }

        public long? FatherId { get; set; }

        public long? MotherId { get; set; }

        public string Mother { get; set; }

        public string MaritalStatus { get; set; }

        public string PartnerName { get; set; }

        public string Profession { get; set; }

        public string Notice { get; set; }
    }
}