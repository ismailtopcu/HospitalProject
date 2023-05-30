using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DtoLayer.Dtos.DoctorDto
{
	public class GetDoctorDto
	{
		public int DoctorID { get; set; }
		public string DoctorName { get; set; }
		public string DoctorSurname { get; set; }
		public string Mail { get; set; }
		public string? Phone { get; set; }
		public string Title { get; set; }
		public string Graduation { get; set; }
		public string ProfessionName { get; set; }
	}
}
