using System;
using System.Collections.Generic;

#nullable disable

namespace RDC.API.SystemParameters.Models
{
    public partial class BulletinArticle
    {
        public int SBulletinArticleId { get; set; }
        public int? SBulletinId { get; set; }
        public int? SArticleId { get; set; }
        public short? SStatusId { get; set; }

        public virtual Article SArticle { get; set; }
        public virtual Bulletin SBulletin { get; set; }
    }
}
