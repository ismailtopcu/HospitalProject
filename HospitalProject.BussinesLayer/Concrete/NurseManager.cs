using HospitalProject.BusinessLayer.Abstrtact;
using HospitalProject.DataAccessLayer.Abstract;
using HospitalProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.BusinessLayer.Concrete
{
	public class NurseManager : INurseService
	{
		private readonly INurseDal _nurseDal;

		public NurseManager(INurseDal nurseDal)
		{
			_nurseDal = nurseDal;
		}

		public void TDelete(Nurse t)
		{
			_nurseDal.Delete(t);
		}

		public Nurse TGetByID(int id)
		{
			return _nurseDal.GetByID(id);
		}

		public List<Nurse> TGetList()
		{
			return _nurseDal.GetList();
		}

		public void TInsert(Nurse t)
		{
			_nurseDal.Insert(t);
		}

		public void TUpdate(Nurse t)
		{
			_nurseDal.Update(t);
		}
	}
}
