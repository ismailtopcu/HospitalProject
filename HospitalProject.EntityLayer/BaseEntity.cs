using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.EntityLayer
{
	public class BaseEntity
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Surname { get; set; }
	}
}
