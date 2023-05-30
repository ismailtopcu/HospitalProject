namespace HospitalProject.DtoLayer.Dtos.PatientDto
{
	public class UpdatePatientDto
	{
		public int PatientID { get; set; }
		public string PatientName { get; set; }
		public string PatientSurname { get; set; }
		public string PatientPhone { get; set; }
		public string PatientMail { get; set; }
		public string PatientAdress { get; set; }
	}
}
