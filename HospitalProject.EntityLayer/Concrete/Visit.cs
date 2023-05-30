namespace HospitalProject.EntityLayer.Concrete
{
	public class Visit
    {
        public int VisitID { get; set; }
		public int DoctorID { get; set; }
		public int PatientID { get; set; }
		public DateTime VisitStartingDate { get; set; }
		public DateTime? VisitEndDate { get; set; }
		public Doctor Doctor { get; set; }
		public Patient Patient { get; set; }
	}
}
