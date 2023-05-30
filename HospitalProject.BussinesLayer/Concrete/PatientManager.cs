using HospitalProject.BusinessLayer.Abstrtact;
using HospitalProject.DataAccessLayer.Abstract;
using HospitalProject.EntityLayer.Concrete;

namespace HospitalProject.BusinessLayer.Concrete
{
	public class PatientManager : IPatientService
	{
		private readonly IPatientDal _patientDal;

		public PatientManager(IPatientDal patientDal)
		{
			_patientDal = patientDal;
		}

		public void TDelete(Patient t)
		{
			_patientDal.Delete(t);
		}

		public Patient TGetByID(int id)
		{
			return _patientDal.GetByID(id);
		}

		public List<Patient> TGetList()
		{
			return _patientDal.GetList();
		}

		public void TInsert(Patient t)
		{
			_patientDal.Insert(t);
		}

		public void TUpdate(Patient t)
		{
			_patientDal.Update(t);
		}
	}
}
