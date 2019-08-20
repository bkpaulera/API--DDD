﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aps19.Infra.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity

    {

        private MySqlContext context = new MySqlContext();



        public void Insert(T obj)

        {

            context.Set<T>().Add(obj);

            context.SaveChanges();

        }



        public void Update(T obj)

        {

            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            context.SaveChanges();

        }



        public void Delete(int id)

        {

            context.Set<T>().Remove(SelectById(id));

            context.SaveChanges();

        }



        public IList<T> Select()

        {

            return context.Set<T>().ToList();

        }



        public T Select(int id)

        {

            return context.Set<T>().Find(id);

        }

    }
}
