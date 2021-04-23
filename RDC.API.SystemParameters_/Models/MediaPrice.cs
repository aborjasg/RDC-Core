using System;
using System.Collections.Generic;

#nullable disable

namespace RDC.API.SystemParameters.Models
{
    public partial class MediaPrice
    {
        public short SMediaPriceId { get; set; }
        public short? SMediaId { get; set; }
        public double? FPriceUnit { get; set; }
        public double? FAxisX { get; set; }
        public double? FAxisY { get; set; }
        public DateTime? DStartDate { get; set; }
        public DateTime? DFinishDate { get; set; }
        public short? SStatus { get; set; }
    }
}
