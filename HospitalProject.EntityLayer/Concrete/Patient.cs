using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.EntityLayer.Concrete
{
	public class Patient
	{
        public int PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string PatientPhone { get; set; }
        public string PatientMail { get; set; }
        public string PatientAdress { get; set; }
		public List<Appointment> Appointments { get; set; }
		public List<Visit> Visits { get; set; }
	}
}
