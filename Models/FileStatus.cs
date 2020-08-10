using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataDemo.Models
{
    public class FileStatus
    {
        public Guid Id { get; set; }

        public string Status { get; set; }

        public IEnumerable<FileFileStatus> FileFileStatuses { get; set; }
    }
}
