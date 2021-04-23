using System;
using System.Collections.Generic;

#nullable disable

namespace RDC.API.SystemParameters.Models
{
    public partial class Contact
    {
        public short SContactId { get; set; }
        public short? SCustomerId { get; set; }
        public string VName { get; set; }
        public string VTelephone { get; set; }
        public string VCellphone { get; set; }
        public string VEmail { get; set; }
        public short? SStatusId { get; set; }

        public virtual Customer SCustomer { get; set; }
    }
}
