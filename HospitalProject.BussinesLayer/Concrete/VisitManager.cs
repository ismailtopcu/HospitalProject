using HospitalProject.BusinessLayer.Abstrtact;
using HospitalProject.DataAccessLayer.Abstract;
using HospitalProject.EntityLayer.Concrete;

namespace HospitalProject.BusinessLayer.Concrete
{
	public class VisitManager : IVisitService
	{
		private readonly IVisitDal _visitDal;

		public VisitManager(IVisitDal visitDal)
		{
			_visitDal = visitDal;
		}

		public void TDelete(Visit t)
		{
			_visitDal.Delete(t);
		}

		public Visit TGetByID(int id)
		{
			return _visitDal.GetByID(id);
		}

		public List<Visit> TGetList()
		{
			return _visitDal.GetList();
		}

		public void TInsert(Visit t)
		{
			_visitDal.Insert(t);
		}

		public void TUpdate(Visit t)
		{
			_visitDal.Update(t);
		}
	}
}
