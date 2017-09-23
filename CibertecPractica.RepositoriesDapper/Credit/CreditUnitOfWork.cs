using CibertecPractica.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using CibertecPractica.Repositories.Credit;

namespace CibertecPractica.RepositoriesDapper.Credit
{
    public class CreditUnitOfWork : IUnitOfWork
    {
        public CreditUnitOfWork(string connectionString)
        {
            Corporations = new CorporationRepository(connectionString);
            Members = new MemberRepository(connectionString);
        }
        public ICorporationRepository Corporations { get;private set; }

        public IMemberRepository Members { get; private set; }
    }
}
