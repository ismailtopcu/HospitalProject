using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DtoLayer.Dtos.AppointmentDto
{
	public class UpdateAppointmentDto
	{
		public int AppointmentID { get; set; }
		public int DoctorID { get; set; }
		public DateTime Date { get; set; }
		public DateTime AppointmentDate { get; set; }
		public bool Status { get; set; }
	}
}
