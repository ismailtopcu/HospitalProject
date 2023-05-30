using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.EntityLayer.Concrete
{
	public class Appointment
	{
        public int AppointmentID { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public DateTime Date { get; set; }
        public DateTime AppointmentDate { get; set; }
        public bool Status { get; set; }
        public Doctor Doctor{ get; set; }
        public Patient Patient{ get; set; }
    }
}
