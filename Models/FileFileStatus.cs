using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ODataDemo.Models
{
    public class FileFileStatus
    {
        [Key]
        public Guid Id { get; set; }

        public Guid FileId { get; set; }
        [ForeignKey("FileId")]
        public File File { get; set; }

        public Guid FileStatusId { get; set; }
        [ForeignKey("FileStatusId")]
        public FileStatus FileStatus { get; set; }
    }
}
