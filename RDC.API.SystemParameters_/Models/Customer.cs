using System;
using System.Collections.Generic;

#nullable disable

namespace RDC.API.SystemParameters.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Bulletins = new HashSet<Bulletin>();
            Contacts = new HashSet<Contact>();
            CustomerSections = new HashSet<CustomerSection>();
        }

        public short SCustomerId { get; set; }
        public string VCode { get; set; }
        public string VName { get; set; }
        public string VAddress { get; set; }
        public string VLogoFile { get; set; }
        public short? SStatusId { get; set; }

        public virtual ICollection<Bulletin> Bulletins { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<CustomerSection> CustomerSections { get; set; }
    }
}
