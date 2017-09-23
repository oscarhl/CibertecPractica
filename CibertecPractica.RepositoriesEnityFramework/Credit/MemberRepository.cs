using CibertecPractica.Models;
using CibertecPractica.Repositories.Credit;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CibertecPractica.RepositoriesEnityFramework.Credit
{
    public class MemberRepository : Repository<Member>, IMemberRepository
    {
        public MemberRepository(DbContext context) : base(context)
        {
        }

        public Member memberSearchByLastnameFirstname(string lastname, string firstname)
        {
            throw new NotImplementedException();
        }
    }
}
