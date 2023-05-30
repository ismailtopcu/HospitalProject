using HospitalProject.DtoLayer.Dtos.AppointmentDto;
using HospitalProject.EntityLayer.Concrete;

namespace HospitalProject.DataAccessLayer.Abstract
{
	public interface IAppointmentDal : IGenericDal<Appointment>
	{
		List<GetAppointmentWithDoctorAndPatientDto> GetAppointmentWithDoctorAndPatient();
		List<GetAppointmentsByDateDto> GetAppointmentsByDate(DateTime dateTime);
	}
}
