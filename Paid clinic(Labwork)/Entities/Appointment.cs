using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Appointment
    { 
        public DateTime Date { get; set; }
        public bool IsHappened { get; set; }
        public  Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
        public Examination Examination { get; set; }
    }
}
