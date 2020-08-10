using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataDemo.Models
{
    public class File
    {
        public Guid Id { get; set; }

        public string ContentType { get; set; }

        public string Filename { get; set; }

        public IEnumerable<FileFileStatus> FileFileStatuses { get; set; }
    }
}
