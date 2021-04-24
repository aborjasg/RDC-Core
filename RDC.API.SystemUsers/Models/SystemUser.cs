namespace RDC.API.SystemUsers.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class SystemUser
    {
        [Key]
        public short sSystemUserId { get; set; }

        [DisplayName("Alias"), StringLength(20), Required]
        public string vAlias { get; set; }

        [DisplayName("Password"), StringLength(20)]
        public string vPassword { get; set; }

        [DisplayName("Rol Type")]
        public short? sRolTypeId { get; set; }

        [DisplayName("Options"), StringLength(100)]
        public string vOptions { get; set; }

        [DisplayName("Active")]
        public bool? bActive { get; set; }

        [DisplayName("Status")]
        public bool? bStatus { get; set; }

        [NotMapped]
        public string vRolType { get; set; }

    }
}
