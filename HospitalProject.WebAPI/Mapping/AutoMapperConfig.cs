using AutoMapper;
using HospitalProject.DtoLayer.Dtos.AppointmentDto;
using HospitalProject.DtoLayer.Dtos.DoctorDto;
using HospitalProject.DtoLayer.Dtos.PatientDto;
using HospitalProject.EntityLayer.Concrete;

namespace HospitalProject.WebAPI.Mapping
{
	public class AutoMapperConfig:Profile
	{
        public AutoMapperConfig()
        {
            CreateMap<CreateDoctorDto, Doctor>().ReverseMap();
            CreateMap<UpdateDoctorDto, Doctor>().ReverseMap();
            CreateMap<GetDoctorDto, Doctor>().ReverseMap();

            CreateMap<CreatePatientDto, Patient>().ReverseMap();
            CreateMap<UpdatePatientDto, Patient>().ReverseMap();

            CreateMap<CreateAppointmentDto, Appointment>().ReverseMap();
            CreateMap<UpdateAppointmentDto, Appointment>().ReverseMap();
            CreateMap<GetAppointmentWithDoctorAndPatientDto, Appointment>().ReverseMap();
        }
    }
}
