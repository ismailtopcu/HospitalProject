using HospitalProject.BusinessLayer.Abstrtact;
using HospitalProject.DataAccessLayer.Abstract;
using HospitalProject.EntityLayer.Concrete;

namespace HospitalProject.BusinessLayer.Concrete
{
	public class ProfessionManager : IProfessionService
	{
		private readonly IProfessionDal _professionDal;

		public ProfessionManager(IProfessionDal professionDal)
		{
			_professionDal = professionDal;
		}

		public void TDelete(Profession t)
		{
			_professionDal.Delete(t);
		}

		public Profession TGetByID(int id)
		{
			return _professionDal.GetByID(id);
		}

		public List<Profession> TGetList()
		{
			return _professionDal.GetList();
		}

		public void TInsert(Profession t)
		{
			_professionDal.Insert(t);
		}

		public void TUpdate(Profession t)
		{
			_professionDal.Update(t);
		}
	}
}
