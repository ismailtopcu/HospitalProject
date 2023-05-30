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
		public List<GetDoctorDto> GetListDoctorWithProfession()
		{
			using (var context = new Context())
			{
				var values = context.Doctors
					.Include(x => x.Profession)
					.Select(x => new GetDoctorDto
					{
						DoctorID = x.DoctorID,
						DoctorName = x.DoctorName,
						DoctorSurname = x.DoctorSurname,
						Mail = x.Mail,
						Phone = x.Phone,
						Graduation = x.Graduation,
						Title = x.Title,
						ProfessionName=x.Profession.ProfessionName
						
					})
					.ToList();

				return values;
			}
		}


	}
}
