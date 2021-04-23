using System;
using System.Collections.Generic;

#nullable disable

namespace RDC.API.SystemParameters.Models
{
    public partial class SystemUser
    {
        public short SSystemUserId { get; set; }
        public string VAlias { get; set; }
        public string VPassword { get; set; }
        public short? SRolTypeId { get; set; }
        public string VOptions { get; set; }
        public bool? BActive { get; set; }
        public bool? BStatus { get; set; }
    }
}
