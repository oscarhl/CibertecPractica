using CibertecPractica.Models;
using CibertecPractica.Repositories.Credit;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CibertecPractica.RepositoriesDapper.Credit
{
    public class MemberRepository : Repository<Member>, IMemberRepository
    {
        public MemberRepository(string conectionString) : base(conectionString)
        {
        }

        public Member memberSearchByLastnameFirstname(string lastname, string firstname)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@lastname", lastname);
                parameters.Add("@firstname", firstname);


                return connection.QueryFirst<Member>(
                    "dbo.memberSearchByLastnameFirstname",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure);

            }
        }
    }
}
