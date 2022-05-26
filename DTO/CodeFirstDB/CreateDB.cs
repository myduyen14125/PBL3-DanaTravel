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

        }
    }
}
