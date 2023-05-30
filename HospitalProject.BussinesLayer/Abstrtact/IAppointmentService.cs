using HospitalProject.DtoLayer.Dtos.AppointmentDto;
using HospitalProject.EntityLayer.Concrete;

namespace HospitalProject.BusinessLayer.Abstrtact
{
	public interface IAppointmentService : IGenericService<Appointment>
	{
		List<GetAppointmentWithDoctorAndPatientDto> TGetAppointmentWithDoctorAndPatient();
		List<GetAppointmentsByDateDto> TGetAppointmentsByDate(DateTime dateTime);
	}
}
