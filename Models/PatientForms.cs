using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ODataDemo.Models
{
    public class PatientForms
    {
        [Key]
        public Guid Id { get; set; }

        public ulong PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }

        public ulong FormId { get; set; }
        [ForeignKey("FormId")]
        public Form Form { get; set; }
    }
}
