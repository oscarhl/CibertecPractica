using CibertecPractica.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CibertecPractica.Repositories.Credit
{
    public interface IMemberRepository:IRepository<Member>
    {

        Member memberSearchByLastnameFirstname(string lastname, string firstname);
    }
}
