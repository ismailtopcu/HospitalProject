using AutoMapper;
using HospitalProject.BusinessLayer.Abstrtact;
using HospitalProject.DtoLayer.Dtos.PatientDto;
using HospitalProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalProject.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class PatientController : ControllerBase
	{
		private readonly IPatientService _patientService;
		private readonly IMapper _mapper;

		public PatientController(IPatientService patientService, IMapper mapper)
		{
			_patientService = patientService;
			_mapper = mapper;
		}

		[HttpGet]
		public IActionResult PatientList()
		{
			var values = _patientService.TGetList();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult AddPatient(CreatePatientDto createPatientDto)
		{
			var values = _mapper.Map<Patient>(createPatientDto);
			_patientService.TInsert(values);
			return Ok();
		}
		[HttpGet("GetByID")]
		public IActionResult GetByID(int id)
		{
			var value = _patientService.TGetByID(id);
			return Ok(value);
		}
		
		[HttpDelete]
		public IActionResult DeletePatient(int id)
		{
			var values = _patientService.TGetByID(id);
			_patientService.TDelete(values);
			return Ok();
		}

		[HttpPut]
		public IActionResult UpdatePatient(UpdatePatientDto updatePatientDto)
		{
			var values = _mapper.Map<Patient>(updatePatientDto);
			_patientService.TUpdate(values);
			return Ok();
		}
	}
}
