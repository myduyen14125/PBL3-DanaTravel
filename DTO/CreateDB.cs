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
    class CreateDB : DropCreateDatabaseIfModelChanges<EntityManager>
    {
        protected override void Seed(EntityManager context)
        {
            List<Permission> permissions = new List<Permission>();
            permissions.Add(new Permission { per_id = 1, per_name = "Create Employee" });
            permissions.Add(new Permission { per_id = 2, per_name = "View Employee" });
            permissions.Add(new Permission { per_id = 3, per_name = "Edit Employee" });
            permissions.Add(new Permission { per_id = 4, per_name = "Delete Employee" });
            permissions.Add(new Permission { per_id = 5, per_name = "Create Customer" });
            permissions.Add(new Permission { per_id = 6, per_name = "View Customer" });
            permissions.Add(new Permission { per_id = 7, per_name = "Edit Customer" });
            permissions.Add(new Permission { per_id = 8, per_name = "Delete Customer" });
            permissions.Add(new Permission { per_id = 9, per_name = "Create Bill" });
            permissions.Add(new Permission { per_id = 10, per_name = "View Bill" });
            permissions.Add(new Permission { per_id = 11, per_name = "Edit Bill" });
            permissions.Add(new Permission { per_id = 12, per_name = "Delete Bill" });
            permissions.Add(new Permission { per_id = 13, per_name = "Create Service" });
            permissions.Add(new Permission { per_id = 14, per_name = "View Service" });
            permissions.Add(new Permission { per_id = 15, per_name = "Edit Service" });
            permissions.Add(new Permission { per_id = 16, per_name = "Delete Service" });
            permissions.Add(new Permission { per_id = 17, per_name = "Statistical" });


            context.Permissions.AddRange(permissions);


            var role = new Role { role_id = 1, role_name = "Admin" };
            foreach (Permission permission in permissions) role.Permissions.Add(permission);
            context.Roles.Add(role);

            //var role1 = new Role { id = 2, name = "Manager" };
            //role1.Permissions.Add(permissions[0]);
            //context.Roles.Add(role1);

            var account = new Account { account_id = 1, username = "daitoan2000@gmail.com", password = HashPassword.GetHash("admin"), status = true };
            account.Roles.Add(role);
            context.Accounts.Add(account);
            context.SaveChanges();
        }
    }
}
