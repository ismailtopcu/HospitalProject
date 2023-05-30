using HospitalProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DataAccessLayer.Concrete
{
	public class Context :DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=ISMAIL\\SQLEXPRESS;initial catalog= HospitalDb; integrated security=true");
		}
		public DbSet<Doctor> Doctors { get; set; }
		public DbSet<Patient> Patients { get; set; }
		public DbSet<Profession> Professions { get; set; }
		public DbSet<Nurse> Nurses { get; set; }
		public DbSet<Receptionist> Receptionists{ get; set; }
		public DbSet<Appointment> Appointments { get; set; }
		public DbSet<Visit> Visits { get; set; }
	}
}
