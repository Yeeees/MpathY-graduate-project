using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;//for Required statement

namespace MpathY.Models
{
    public class Organisation
    {
        public int OrgId { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

    }
}