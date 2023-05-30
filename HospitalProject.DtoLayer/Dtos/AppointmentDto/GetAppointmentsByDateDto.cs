using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DtoLayer.Dtos.AppointmentDto
{
	public class GetAppointmentsByDateDto
	{
		public int AppointmentID { get; set; }
		public string DoctorName { get; set; }
		public string PatientName { get; set; }
		public DateTime Date { get; set; }
		public DateTime AppointmentDate { get; set; }
	}
}
