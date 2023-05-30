using HospitalProject.BusinessLayer.Abstrtact;
using HospitalProject.DataAccessLayer.Abstract;
using HospitalProject.EntityLayer.Concrete;

namespace HospitalProject.BusinessLayer.Concrete
{
	public class ReceptionistManager : IReceptionistService
	{
		private readonly IReceptionistDal _receptionistDal;

		public ReceptionistManager(IReceptionistDal receptionistDal)
		{
			_receptionistDal = receptionistDal;
		}

		public void TDelete(Receptionist t)
		{
			_receptionistDal.Delete(t);
		}

		public Receptionist TGetByID(int id)
		{
			return _receptionistDal.GetByID(id);
		}

		public List<Receptionist> TGetList()
		{
			return _receptionistDal.GetList();
		}

		public void TInsert(Receptionist t)
		{
			_receptionistDal.Insert(t);
		}

		public void TUpdate(Receptionist t)
		{
			_receptionistDal.Update(t);
		}
	}
}
