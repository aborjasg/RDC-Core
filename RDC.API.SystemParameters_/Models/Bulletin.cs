using System;
using System.Collections.Generic;

#nullable disable

namespace RDC.API.SystemParameters.Models
{
    public partial class Bulletin
    {
        public Bulletin()
        {
            BulletinArticles = new HashSet<BulletinArticle>();
        }

        public int SBulletinId { get; set; }
        public short? SCustomerId { get; set; }
        public DateTime DRegisterDate { get; set; }
        public short? SStatusId { get; set; }
        public short? SAuthorId { get; set; }

        public virtual Customer SCustomer { get; set; }
        public virtual ICollection<BulletinArticle> BulletinArticles { get; set; }
    }
}
