﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.EntityLayer.Concrete
{
	public class AppUser : IdentityUser
	{
		public string Name { get; set; }
		public string Surname { get; set; }
		public string City { get; set; }
		public string Gender { get; set; }
		public string ImageUrl { get; set; }
	}
}
