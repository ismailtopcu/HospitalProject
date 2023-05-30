using HospitalProject.BusinessLayer.Abstrtact;
using HospitalProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalProject.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProfessionController : ControllerBase
	{
		private readonly IProfessionService _professionService;

		public ProfessionController(IProfessionService professionService)
		{
			_professionService = professionService;
		}

		[HttpGet]
		public IActionResult ListProfession()
		{
			var values = _professionService.TGetList();
			return Ok(values);
		}
		[HttpGet("GetByID")]
		public IActionResult GetProfession(int id)
		{
			var value = _professionService.TGetByID(id);
			return Ok(value);
		}
		[HttpPost]
		public IActionResult AddProfession(Profession profession)
		{
			_professionService.TInsert(profession);
			return Ok();
		}
		[HttpPut]
		public IActionResult UpdateProfession(Profession profession)
		{
			_professionService.TUpdate(profession);
			return Ok();
		}
		[HttpDelete]
		public IActionResult DeleteProfession(int id)
		{
			var value = _professionService.TGetByID(id);
			_professionService.TDelete(value);
			return Ok();
		}


	}
}
