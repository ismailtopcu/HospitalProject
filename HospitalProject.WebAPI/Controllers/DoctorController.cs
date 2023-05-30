using AutoMapper;
using HospitalProject.BusinessLayer.Abstrtact;
using HospitalProject.DataAccessLayer.Concrete;
using HospitalProject.DtoLayer.Dtos.DoctorDto;
using HospitalProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HospitalProject.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DoctorController : ControllerBase
	{
		private readonly IDoctorService _doctorService;
		private readonly IMapper _mapper;

		public DoctorController(IDoctorService doctorService, IMapper mapper)
		{
			_doctorService = doctorService;
			_mapper = mapper;
		}

		[HttpGet("WithProfession")]
		public IActionResult DoctorListWithProfession()
		{
			var values = _doctorService.TGetListDoctorWithProfession();
			return Ok(values);
		}
		[HttpGet]
		public IActionResult DoctorList()
		{
			var values = _doctorService.TGetList();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddDoctor(CreateDoctorDto createDoctorDto)
		{
			var values = _mapper.Map<Doctor>(createDoctorDto);
			_doctorService.TInsert(values);
			return Ok();
		}
		[HttpDelete]
		public IActionResult DeleteDoctor(int id)
		{
			var values=_doctorService.TGetByID(id);
			_doctorService.TDelete(values);
			return Ok();
		}

		[HttpGet("GetByID")]
		public IActionResult GetDoctor(int id)
		{
			var value =_doctorService.TGetByID(id);
			return Ok(value);
		}
		[HttpPut]
		public IActionResult UpdateDoctor(UpdateDoctorDto updateDoctorDto)
		{
			var values = _mapper.Map<Doctor>(updateDoctorDto);
			_doctorService.TUpdate(values);
			return Ok();	
		}
	}
}
