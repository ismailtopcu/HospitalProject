﻿using AutoMapper;
using HospitalProject.DataAccessLayer.Abstract;
using HospitalProject.DataAccessLayer.Concrete;
using HospitalProject.DataAccessLayer.Repositories;
using HospitalProject.DtoLayer.Dtos.AppointmentDto;
using HospitalProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace HospitalProject.DataAccessLayer.EntityFramework
{
	public class EfAppointmentDal : GenericRepository<Appointment>, IAppointmentDal
	{
		public List<GetAppointmentsByDateDto> GetAppointmentsByDate(DateTime dateTime)
		{
			using(var context  = new Context())
			{

				var appointmentsByDate = context.Appointments.Where(x=>x.AppointmentDate.Date==dateTime.Date).Include(x=>x.Doctor).Include(x=>x.Patient).ToList();
				var values = appointmentsByDate.Select(appointment => new GetAppointmentsByDateDto()
				{
					AppointmentID= appointment.AppointmentID,
					AppointmentDate = appointment.AppointmentDate,
					Date=appointment.Date,
					DoctorName= appointment.Doctor.Title + " " + appointment.Doctor.DoctorName + " " + appointment.Doctor.DoctorSurname,
					PatientName = appointment.Patient.PatientName + " " + appointment.Patient.PatientSurname
				}).ToList();
				return values;
			}
		}

		public List<GetAppointmentWithDoctorAndPatientDto> GetAppointmentWithDoctorAndPatient()
		{
			using (var context = new Context())
			{
				var appointmentList = context.Appointments.Include(x=>x.Doctor).Include(x=>x.Patient).ToList();
				var values = appointmentList.Select(appointment => new GetAppointmentWithDoctorAndPatientDto()
				{
					AppointmentID = appointment.AppointmentID,
					DoctorName= appointment.Doctor.Title + " "+ appointment.Doctor.DoctorName + " " + appointment.Doctor.DoctorSurname,
					PatientName= appointment.Patient.PatientName + " " + appointment.Patient.PatientSurname,
					Date=DateTime.Now,
					AppointmentDate= appointment.AppointmentDate
				}).ToList();

				return values;
			}
		}
	}
}
