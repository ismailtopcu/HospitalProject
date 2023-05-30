﻿using HospitalProject.DataAccessLayer.Abstract;
using HospitalProject.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.DataAccessLayer.Repositories
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		

		public void Delete(T t)
		{
			using var context = new Context();
			context.Remove(t);
			context.SaveChanges();
		}

		public T GetByID(int id)
		{
			using var context = new Context();
			return context.Set<T>().Find(id);
		}

		public List<T> GetList()
		{
			using var context = new Context();
			return context.Set<T>().ToList();
		}

		public void Insert(T T)
		{
			using var context = new Context();
			context.Add(T);
			context.SaveChanges();
		}

		public void Update(T T)
		{
			using var context = new Context();
			context.Update(T);
			context.SaveChanges();
		}
	}
}
