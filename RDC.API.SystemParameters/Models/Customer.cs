using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RDC.API.SystemParameters.Models
{
    public partial class Customer
    {
        public Customer()
        {
           
        }
        [Key]
        public short SCustomerId { get; set; }
        public string VCode { get; set; }
        public string VName { get; set; }
        public string VAddress { get; set; }
        public string VLogoFile { get; set; }
        public short? SStatusId { get; set; }

    }
}
