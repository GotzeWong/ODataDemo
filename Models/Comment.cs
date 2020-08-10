using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataDemo.Models
{
    public class Comment
    {

        public int CommentId { get; set; }
        public string Content { get; set; }

        public Comment comment { get; set; }
    }
}
