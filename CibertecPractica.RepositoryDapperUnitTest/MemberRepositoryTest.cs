using CibertecPractica.Models;
using CibertecPractica.RepositoriesDapper.Credit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace CibertecPractica.RepositoryDapperUnitTest
{
    class MemberRepositoryTest
    {
        private readonly CreditUnitOfWork unit;

        public MemberRepositoryTest()
        {
            unit = new CreditUnitOfWork("Server=.;Database=Credit; Trusted_Connection=True;MultipleActiveResultSets=True");
        }
        

        [Fact(DisplayName = "[MemberRepository]Get All")]
        public void Member_Repository_GetAll()
        {
            var result = unit.Members.GetList();
            Assert.True(result.Count() > 0);
        }

        //[Fact(DisplayName = "[MemberRepository]Insert")]
        //public void Member_Repository_Insert()
        //{
        //    var member = GetNewMember();
        //    var result = unit.Members.Insert(member);
        //    Assert.True(result > 0);
        //}

        //[Fact(DisplayName = "[MemberRepository]Delete")]
        //public void Corporation_Repository_Delete()
        //{
        //    var member = GetNewMember();
        //    var result = unit.Members.Insert(member);
        //    Assert.True(unit.Members.Delete(member));
        //}

        //private Member GetNewMember()
        //{
        //    return new Member
        //    {
        //       member_no= 774,
        //       lastname="TOLSKY",
        //       firstname=",
        //       middleinitial,
        //       street,
        //       city,
        //       state_prov,
        //       country,
        //       mail_code,
        //       phone_no,
        //        issue_dt,
        //        expr_dt,
        //        corp_no,
        //        prev_balance,
        //        curr_balance,
        //        member_code
                
                
        //        VALUES (774, N'TOLSKY', N'NWIW', N' ', N' ', N' ', N'  ', N'  ', N'          ', N'             ', CAST(N'1999-10-12 10:41:42.267' AS DateTime), CAST(N'2000-10-12 10:41:42.267' AS DateTime), NULL, 0.0000, 0.0000, N'  ')
        //    };
        //}

        [Fact(DisplayName = "[MemberRepository]Update")]
        public void Corporation_Repository_Update()
        {
            var member = unit.Members.GetById(10);
            Assert.True(member != null);
            member.lastname = "Ciberted";
            Assert.True(unit.Members.Update(member));
        }

        [Fact(DisplayName = "[MemberRepository]Get By Id")]
        public void Corporation_Repository_Get_By_Id()
        {
            var corporation = unit.Members.GetById(10);
            Assert.True(corporation != null);
        }

        [Fact(DisplayName = "[MemberRepository]Get By Nombre")]
        public void memberSearchByLastnameFirstname()
        {
            var member = unit.Members.memberSearchByLastnameFirstname("ANDERSON", "QDQRJVEINMJYHK");
            Assert.True(member != null);
        }
    }
}
