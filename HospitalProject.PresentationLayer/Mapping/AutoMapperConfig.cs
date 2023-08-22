using AutoMapper;
using HospitalProject.DtoLayer.Dtos.DoctorDto;
using HospitalProject.EntityLayer.Concrete;


namespace HospitalProject.PresentationLayer.Mapping
{
    public class AutoMapperConfig:Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<GetDoctorDto, Doctor>().ReverseMap();
            CreateMap<CreateDoctorDto, Doctor>().ReverseMap();
            CreateMap<UpdateDoctorDto, Doctor>().ReverseMap();
        }
    }
}
