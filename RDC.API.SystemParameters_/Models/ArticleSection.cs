using System;
using System.Collections.Generic;

#nullable disable

namespace RDC.API.SystemParameters.Models
{
    public partial class ArticleSection
    {
        public int SArticleSectionId { get; set; }
        public int SArticleId { get; set; }
        public short SSectionId { get; set; }
        public short? SStatusId { get; set; }

        public virtual Article SArticle { get; set; }
    }
}
