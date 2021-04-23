using System;
using System.Collections.Generic;

#nullable disable

namespace RDC.API.SystemParameters.Models
{
    public partial class Article
    {
        public Article()
        {
            ArticleElements = new HashSet<ArticleElement>();
            ArticleSections = new HashSet<ArticleSection>();
            BulletinArticles = new HashSet<BulletinArticle>();
        }

        public int SArticleId { get; set; }
        public short SMediaId { get; set; }
        public short SArticleTypeId { get; set; }
        public DateTime DRegisterDate { get; set; }
        public short? SStatusId { get; set; }
        public short? SAuthorId { get; set; }
        public double? FPriceCost { get; set; }
        public bool? BPublish { get; set; }
        public string VBroadcastSource { get; set; }
        public string VBroadcastHour { get; set; }
        public string VBroadcastDuration { get; set; }
        public short? SPressSectionId { get; set; }
        public string VPressPage { get; set; }
        public string VDescription { get; set; }
        public short? STemplateTypeId { get; set; }
        public string VTitle { get; set; }

        public virtual Medium SMedia { get; set; }
        public virtual ICollection<ArticleElement> ArticleElements { get; set; }
        public virtual ICollection<ArticleSection> ArticleSections { get; set; }
        public virtual ICollection<BulletinArticle> BulletinArticles { get; set; }
    }
}
