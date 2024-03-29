using AutoMapper;
using HospitalProject.BusinessLayer.Abstrtact;
using HospitalProject.BusinessLayer.Concrete;
using HospitalProject.DataAccessLayer.Abstract;
using HospitalProject.DataAccessLayer.Concrete;
using HospitalProject.DataAccessLayer.EntityFramework;
using HospitalProject.DtoLayer.Dtos.DoctorDto;
using HospitalProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IDoctorDal,EfDoctorDal>();
builder.Services.AddScoped<IDoctorService,DoctorManager>(); 

builder.Services.AddScoped<IPatientDal,EfPatientDal>();
builder.Services.AddScoped<IPatientService,PatientManager>();

builder.Services.AddScoped<IAppointmentDal, EfAppointmentDal>();
builder.Services.AddScoped<IAppointmentService, AppointmentManager>();

builder.Services.AddScoped<IVisitDal, EfVisitDal>();
builder.Services.AddScoped<IVisitService, VisitManager>();

builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser,IdentityRole>().AddEntityFrameworkStores<Context>().AddDefaultTokenProviders();

builder.Services.AddAutoMapper(typeof(Program));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
