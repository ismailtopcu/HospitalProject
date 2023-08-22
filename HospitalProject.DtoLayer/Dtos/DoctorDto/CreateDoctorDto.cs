using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DtoLayer.Dtos.DoctorDto
{
	public class CreateDoctorDto
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string? Mail { get; set; }
		public string? Phone { get; set; }
		public string? Title { get; set; }
		
	}
    
}
