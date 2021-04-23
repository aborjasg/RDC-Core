using System;
using System.Collections.Generic;

#nullable disable

namespace RDC.API.SystemParameters.Models
{
    public partial class Medium
    {
        public Medium()
        {
            Articles = new HashSet<Article>();
        }

        public short SMediaId { get; set; }
        public short? SMediaTypeId { get; set; }
        public string VName { get; set; }
        public string VLogoFile { get; set; }
        public short? SStatusId { get; set; }
        public string VReadership { get; set; }
        public double? DPrice { get; set; }
        public double? FAxisX { get; set; }
        public double? FAxisY { get; set; }
        public double? FPriceUnit { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}
