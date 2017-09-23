using CibertecPractica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CibertecPractica.Repositories.Credit
{
    public interface ICorporationRepository: IRepository<Corporation>
    {
        Corporation CorporationSearchByCorp_name(string NameCorp);
    }
}
