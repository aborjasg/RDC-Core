using System;
using System.Collections.Generic;

#nullable disable

namespace RDC.API.SystemParameters.Models
{
    public partial class ArticleElement
    {
        public int SArticleElementId { get; set; }
        public int SArticleId { get; set; }
        public short SElementTypeId { get; set; }
        public string VFileId { get; set; }
        public string VFilePath { get; set; }
        public string VFileName { get; set; }
        public double? FFileSize { get; set; }
        public short? SPixelWidth { get; set; }
        public short? SPixelHeight { get; set; }
        public short? SZoomPercentage { get; set; }
        public bool? BTitlePage { get; set; }
        public string VContain { get; set; }
        public short? SOrder { get; set; }
        public short? SStatusId { get; set; }

        public virtual Article SArticle { get; set; }
    }
}
