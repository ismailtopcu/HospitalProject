using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DtoLayer.Dtos.PatientDto
{
	public class CreatePatientDto
	{
		public string PatientName { get; set; }
		public string PatientSurname { get; set; }
		public string PatientPhone { get; set; }
		public string PatientMail { get; set; }
		public string PatientAdress { get; set; }
	}
}
