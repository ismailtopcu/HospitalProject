using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.EntityLayer.Concrete
{
	public class Profession
	{
        public int ProfessionID { get; set; }
        public string ProfessionName { get; set; }
        public List<Doctor> Doctors { get; set; }
    }
}
