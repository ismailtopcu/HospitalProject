using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DtoLayer.Dtos.PatientDto
{
	public class CreatePatientDto
	{
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
    }
}
