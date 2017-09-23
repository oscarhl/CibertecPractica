﻿using CibertecPractica.Repositories;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CibertecPractica.RepositoriesDapper
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected string _connectionString;

        public Repository(string conectionString)
        {
            SqlMapperExtensions.TableNameMapper = (Type) => { return $"{Type.Name}"; };
            _connectionString =conectionString;
        }

        public bool Delete(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Delete(entity);
            }
        }

        public T GetById(int Id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Get<T>(Id);
            }
        }

        public IEnumerable<T> GetList()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.GetAll<T>();
            }
        }

        public int Insert(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return (int)connection.Insert<T>(entity);
            }
        }

        public bool Update(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Update<T>(entity);
            }
        }
    }
}
