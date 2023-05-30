using HospitalProject.BusinessLayer.Abstrtact;
using HospitalProject.DataAccessLayer.Abstract;
using HospitalProject.DtoLayer.Dtos.AppointmentDto;
using HospitalProject.EntityLayer.Concrete;

namespace HospitalProject.BusinessLayer.Concrete
{
	public class AppointmentManager : IAppointmentService
	{
		private readonly IAppointmentDal _appointmentDal;

		public AppointmentManager(IAppointmentDal appointmentDal)
		{
			_appointmentDal = appointmentDal;
		}

		public void TDelete(Appointment t)
		{
			_appointmentDal.Delete(t);
		}

		public List<GetAppointmentsByDateDto> TGetAppointmentsByDate(DateTime dateTime)
		{
			return _appointmentDal.GetAppointmentsByDate(dateTime);
		}

		public List<GetAppointmentWithDoctorAndPatientDto> TGetAppointmentWithDoctorAndPatient()
		{
			return _appointmentDal.GetAppointmentWithDoctorAndPatient();
			
		}

		public Appointment TGetByID(int id)
		{
			return _appointmentDal.GetByID(id);
		}

		public List<Appointment> TGetList()
		{
			return _appointmentDal.GetList();
		}

		public void TInsert(Appointment t)
		{
			_appointmentDal.Insert(t);
		}

		public void TUpdate(Appointment t)
		{
			_appointmentDal.Update(t);
		}
	}
}
