using CibertecPractica.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using CibertecPractica.Repositories.Credit;
using Microsoft.EntityFrameworkCore;

namespace CibertecPractica.RepositoriesEnityFramework.Credit
{
    public class CreditUnitOfWork : IUnitOfWork
    {
        public CreditUnitOfWork(DbContext context)
        {
            Corporations = new CorporationRepository(context);
            Members = new MemberRepository(context);
        }

        public ICorporationRepository Corporations { get; private set; }

        public IMemberRepository Members { get; private set; }
    }
}
