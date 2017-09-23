using CibertecPractica.Models;
using CibertecPractica.Repositories.Credit;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace CibertecPractica.RepositoriesDapper.Credit
{
    public class CorporationRepository : Repository<Corporation>, ICorporationRepository
    {
        public CorporationRepository(string conectionString) : base(conectionString)
        {
        }

        public Corporation CorporationSearchByCorp_name(string NameCorp)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Corp_name", NameCorp);
              

                return connection.QueryFirst<Corporation>(
                    "dbo.CorporationSearchByCorp_name",
                    parameters,
                    commandType: System.Data.CommandType.StoredProcedure);

            }
        }
    }
}
