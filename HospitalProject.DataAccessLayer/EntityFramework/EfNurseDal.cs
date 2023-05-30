using HospitalProject.DataAccessLayer.Abstract;
using HospitalProject.DataAccessLayer.Repositories;
using HospitalProject.EntityLayer.Concrete;

namespace HospitalProject.DataAccessLayer.EntityFramework
{
	public class EfNurseDal : GenericRepository<Nurse>, INurseDal
	{
	}
}
