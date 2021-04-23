using System;
using System.Collections.Generic;

#nullable disable

namespace RDC.API.SystemParameters.Models
{
    public partial class SystemSection
    {
        public short SSectionId { get; set; }
        public short? SParentId { get; set; }
        public string VName { get; set; }
        public short? SOrder { get; set; }
        public bool? BVisible { get; set; }
        public bool? BStatus { get; set; }
    }
}
