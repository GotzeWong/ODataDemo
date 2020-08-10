using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataDemo.Models
{
    public class Form
    {
        public ulong FormId { get; set; }
        public string Name { get; set; }

        public ICollection<PatientForms> PatientForms { get; set; }
    }
}
