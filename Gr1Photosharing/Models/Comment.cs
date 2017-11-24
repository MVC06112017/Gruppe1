using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gr1Photosharing.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public int PhotoID { get; set; }
        public string UserName { get; set; }
        public string Subject { get; set; }
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }
        public virtual Photo Photo { get; set; }
    }
}