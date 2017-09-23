using CibertecPractica.Models;
using CibertecPractica.RepositoriesDapper.Credit;
using System;
using System.Linq;
using Xunit;

namespace CibertecPractica.RepositoryDapperUnitTest
{
    public class CorporationRepositoryTest
    {
        private readonly CreditUnitOfWork unit;

        public CorporationRepositoryTest()
        {
            unit = new CreditUnitOfWork("Server=.;Database=Credit; Trusted_Connection=True;MultipleActiveResultSets=True");
        }
      
        [Fact(DisplayName = "[CorporationRepository]Get All")]
        public void Corporation_Repository_GetAll()
        {
            var result = unit.Corporations.GetList();
            Assert.True(result.Count() > 0);
        }

        [Fact(DisplayName = "[CorporationRepository]Insert")]
        public void Corporation_Repository_Insert()
        {
            var corporation = GetNewCorporation();
            var result = unit.Corporations.Insert(corporation);
            Assert.True(result > 0);
        }

        [Fact(DisplayName = "[CorporationRepository]Delete")]
        public void Corporation_Repository_Delete()
        {
            var corporation = GetNewCorporation();
            var result = unit.Corporations.Insert(corporation);
            Assert.True(unit.Corporations.Delete(corporation));
        }

        private Corporation GetNewCorporation()
        {
            return new Corporation
            {
               corp_no=1000,
               corp_name= "Serpico EIRL",
               street=string.Empty,
               city= string.Empty,
               state_prov= string.Empty,
               country= string.Empty,
               mail_code= string.Empty,
               phone_no= string.Empty,
               expr_dt= DateTime.Now,
               corp_code= string.Empty                   
            };
        }

        [Fact(DisplayName = "[CorporationRepository]Update")]
        public void Corporation_Repository_Update()
        {
            var corporation = unit.Corporations.GetById(10);
            Assert.True(corporation != null);
            corporation.corp_name = "Ciberted";
            Assert.True(unit.Corporations.Update(corporation));
        }

        [Fact(DisplayName = "[CorporationRepository]Get By Id")]
        public void Corporation_Repository_Get_By_Id()
        {
            var corporation = unit.Corporations.GetById(10);
            Assert.True(corporation != null);
        }

        [Fact(DisplayName = "[CorporationRepository]Get By Nombre")]
        public void CorporationSearchByCorp_name()
        {
            var corporation = unit.Corporations.CorporationSearchByCorp_name("Corp. Apex QuestsInc.");
            Assert.True(corporation != null);
        }
    }
}
