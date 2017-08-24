using Emigrace.Core.Database;
using Emigrace.Core.Database.Generated;
using Emigrace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Emigrace.Services
{
    public class LibraryService
    {
        private readonly Repository<Person> repository = new Repository<Person>();

        public IEnumerable <PersonViewModel> SelectAllPersons(SearchViewModel model)
        {

            return new List<PersonViewModel>() {
                new PersonViewModel
                {
                    FamilyName = "Kazyrevich",
                    Name = "Andrew",
                    FatherName = "Alexander"
                }, 
                new PersonViewModel
                {
                    FamilyName = "Novak",
                    Name = "Andrew",
                }

            };
        }
    }
}