using System;
using System.Collections.Generic;

namespace ContactManagmentSystem.Interface
{
    public class Person
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public long GovIdentityNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public Gender Gender { get; set; }

        public IEnumerable<Phone> Phones { get; set; }

        public IEnumerable<Address> Adresses { get; set; }

        public IEnumerable<EmailAddress> EmailAddresses { get; set; }

        public IEnumerable<SocialMedia> SocialMedias { get; set; }


    }
}