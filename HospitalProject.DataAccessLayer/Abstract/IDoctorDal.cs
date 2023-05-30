using HospitalProject.DtoLayer.Dtos.DoctorDto;
using HospitalProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DataAccessLayer.Abstract
{
	public interface IDoctorDal:IGenericDal<Doctor>
	{
		List<GetDoctorDto> GetListDoctorWithProfession();
	}
}
