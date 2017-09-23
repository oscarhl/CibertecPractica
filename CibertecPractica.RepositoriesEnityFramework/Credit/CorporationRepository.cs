using CibertecPractica.Models;
using CibertecPractica.Repositories.Credit;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CibertecPractica.RepositoriesEnityFramework.Credit
{
    public class CorporationRepository : Repository<Corporation>, ICorporationRepository
    {
        public CorporationRepository(DbContext context) : base(context)
        {
        }

        public Corporation CorporationSearchByCorp_name(string NameCorp)
        {
            throw new NotImplementedException();
        }
    }
}
