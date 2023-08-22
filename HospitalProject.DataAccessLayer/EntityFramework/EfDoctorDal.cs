using HospitalProject.DataAccessLayer.Abstract;
using HospitalProject.DataAccessLayer.Concrete;
using HospitalProject.DataAccessLayer.Repositories;
using HospitalProject.DtoLayer.Dtos.DoctorDto;
using HospitalProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DataAccessLayer.EntityFramework
{
	public class EfDoctorDal : GenericRepository<Doctor>, IDoctorDal
	{
		


	}
}
