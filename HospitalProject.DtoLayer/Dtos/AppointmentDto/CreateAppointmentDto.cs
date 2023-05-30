using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DtoLayer.Dtos.AppointmentDto
{
	public class CreateAppointmentDto
	{
		public int DoctorID { get; set; }
		public int PatientID { get; set; }
		public DateTime Date { get; set; }
		public DateTime AppointmentDate { get; set; }
	}
}
