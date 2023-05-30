using AutoMapper;
using HospitalProject.BusinessLayer.Abstrtact;
using HospitalProject.DtoLayer.Dtos.AppointmentDto;
using HospitalProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalProject.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AppointmentController : ControllerBase
	{
		private readonly IAppointmentService _appointmentService;
		private readonly IMapper _mapper;


		public AppointmentController(IAppointmentService appointmentService, IMapper mapper)
		{
			_appointmentService = appointmentService;
			_mapper = mapper;
		}
		[HttpGet("ListAppointment")]
		public IActionResult ListAppointment()
		{
			var values = _appointmentService.TGetAppointmentWithDoctorAndPatient();
			return Ok(values);
		}
		[HttpPost("AddAppointment")]
		public IActionResult AddAppointment(CreateAppointmentDto createAppointmentDto)
		{
			Appointment appointment = new Appointment()
			{
				DoctorID=createAppointmentDto.DoctorID,
				PatientID=createAppointmentDto.PatientID,
				Date = DateTime.Now,
				AppointmentDate = createAppointmentDto.AppointmentDate
			};
			_appointmentService.TInsert(appointment);
			return Ok();
		}
		[HttpDelete("DeleteAppointment")]
		public IActionResult DeleteAppointment(int id)
		{
			var value = _appointmentService.TGetByID(id);
			_appointmentService.TDelete(value);
			return Ok();
		}
		[HttpGet("GetByID")]
		public IActionResult GetAppointmentById(int id)
		{
			var value = _appointmentService.TGetByID(id);
			return Ok(value);
		}
		[HttpPut("UpdateAppointmentWithDto")]
		public IActionResult UpdateAppointmentWithDto(UpdateAppointmentDto updateAppointmentDto)
		{
			var value = _mapper.Map<Appointment>(updateAppointmentDto);
			_appointmentService.TUpdate(value);
			return Ok("Randevu Başarıyla Güncellendi");
		}
		[HttpGet("GetAppointmentsByDate")]
		public IActionResult GetAppointmentsByDate(DateTime date)
		{
			var values = _appointmentService.TGetAppointmentsByDate(date);
			return Ok(values);
		}
	}
}
