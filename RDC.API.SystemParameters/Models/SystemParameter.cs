using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace RDC.API.SystemParameters.Models
{
    public partial class SystemParameter
    {
        [Key]
        public short SParameterId { get; set; }
        
        public short SGroupId { get; set; }
        public string VName { get; set; }
        public string VValue { get; set; }
        public short? SOrder { get; set; }
        public bool? BVisible { get; set; }
        public bool? BStatus { get; set; }
    }
}
