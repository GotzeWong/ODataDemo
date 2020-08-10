using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataDemo.Models
{
    public class Patient
    {
        public ulong PatientId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public DateTime PurchaseDateTime { get; set; }
        public ICollection<PatientForms> PatientForms { get; set; }


        public Patient ErrorProperty { get { throw new Exception(); } set { } }

    }
}
