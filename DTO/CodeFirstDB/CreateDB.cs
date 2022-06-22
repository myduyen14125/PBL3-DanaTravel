using DTO.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace DTO
{
    class CreateDB : CreateDatabaseIfNotExists<EntityManager>
    {
        protected override void Seed(EntityManager context)
        {
            Account ac = new Account
            {
                username = "daitoan",
                password = "123"
            };
            context.Accounts.Add(ac);
            context.SaveChanges();
            //SinhVien sv = new SinhVien
            //{
            //    name = "Nguyễn văn á",
            //    age = 20
            //};
            //context.SinhVien.Add(sv);
            //context.SaveChanges();
        }
    }
}
