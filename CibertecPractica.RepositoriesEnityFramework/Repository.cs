﻿using CibertecPractica.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CibertecPractica.RepositoriesEnityFramework
{
    public class Repository<T> : IRepository<T> where T : class
    {

        protected DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public bool Delete(T entity)
        {
            _context.Remove(entity);
            return _context.SaveChanges() > 0;
        }

        public T GetById(int Id)
        {
            return _context.Set<T>().Find(Id);
        }

        public IEnumerable<T> GetList()
        {
            return _context.Set<T>();
        }

        public int Insert(T entity)
        {
            _context.Add(entity);
            return _context.SaveChanges();
        }

        public bool Update(T entity)
        {
            _context.Update(entity);
            return _context.SaveChanges() > 0;
        }
    }
}
