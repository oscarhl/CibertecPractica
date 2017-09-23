using CibertecPractica.Repositories.Credit;
using System;
using System.Collections.Generic;
using System.Text;

namespace CibertecPractica.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICorporationRepository Corporations { get; }

        IMemberRepository Members { get; }
    }
}
