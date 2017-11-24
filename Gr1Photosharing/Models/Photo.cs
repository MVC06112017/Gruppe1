using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gr1Photosharing.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }
        public string Title { get; set; }

        [DisplayName("Picture")]
        public byte[] PhotoFile { get; set; }
        public string MIMEType { get; set; }
        public string Description { get; set; }

        [DisplayName("Created Date")]
        [DisplayFormat(DataFormatString = "{0: dd-MM-yy")]
        public DateTime CreatedDate { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}