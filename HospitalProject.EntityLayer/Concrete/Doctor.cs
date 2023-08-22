using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.EntityLayer.Concrete
{
	public class Doctor : BaseEntity
	{
        
        public string Mail { get; set; }
        public string? Phone { get; set; }
        public string Title { get; set; }
        public List<Appointment> Appointments { get; set; }
        public List<Visit> Visits { get; set; }
    }
}
