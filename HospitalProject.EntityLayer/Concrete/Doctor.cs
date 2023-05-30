using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.EntityLayer.Concrete
{
	public class Doctor
	{
        public int DoctorID { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSurname { get; set; }  
        public string Mail { get; set; }
        public string? Phone { get; set; }
        public string Title { get; set; }
        public string Graduation { get; set; }
        public int ProfessionID { get; set; }
        public Profession Profession { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Visit> Visits { get; set; }
    }
}
