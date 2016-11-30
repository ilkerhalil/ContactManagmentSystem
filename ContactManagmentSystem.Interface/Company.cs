using System.Collections.Generic;

namespace ContactManagmentSystem.Interface
{
    public class Company
    {
        public string Name { get; set; }

        public string TaxNumber { get; set; }

        public IEnumerable<Person> CompanyPeople { get; set; }

        public IEnumerable<Phone> Phones { get; set; }

        public IEnumerable<Address> Adresses { get; set; }

        public IEnumerable<EmailAddress> EmailAddresses { get; set; }

        public IEnumerable<SocialMedia> SocialMedias { get; set; }
    }
}