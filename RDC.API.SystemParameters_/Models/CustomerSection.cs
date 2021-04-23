using System;
using System.Collections.Generic;

#nullable disable

namespace RDC.API.SystemParameters.Models
{
    public partial class CustomerSection
    {
        public int SCustomerSectionId { get; set; }
        public short SCustomerId { get; set; }
        public short SSectionId { get; set; }
        public short? SStatusId { get; set; }
        public short? SOrder { get; set; }

        public virtual Customer SCustomer { get; set; }
    }
}
