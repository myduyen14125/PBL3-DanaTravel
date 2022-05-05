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
    class CreateDB : DropCreateDatabaseAlways<EntityManager>
    {
        protected override void Seed(EntityManager context)
        {
            // Thêm permission vào database
            //List<Permission> permissions = new List<Permission>();
            //permissions.Add(new Permission { id = 1, name = "Create Employee" });
            //permissions.Add(new Permission { id = 2, name = "View Employee" });
            //permissions.Add(new Permission { id = 3, name = "Edit Employee" });
            //permissions.Add(new Permission { id = 4, name = "Delete Employee" });
            //permissions.Add(new Permission { id = 5, name = "Create Customer" });
            //permissions.Add(new Permission { id = 6, name = "View Customer" });
            //permissions.Add(new Permission { id = 7, name = "Edit Customer" });
            //permissions.Add(new Permission { id = 8, name = "Delete Customer" });
            //permissions.Add(new Permission { id = 9, name = "Create Bill" });
            //permissions.Add(new Permission { id = 10, name = "View Bill" });
            //permissions.Add(new Permission { id = 11, name = "Edit Bill" });
            //permissions.Add(new Permission { id = 12, name = "Delete Bill" });
            //permissions.Add(new Permission { id = 13, name = "Create Service" });
            //permissions.Add(new Permission { id = 14, name = "View Service" });
            //permissions.Add(new Permission { id = 15, name = "Edit Service" });
            //permissions.Add(new Permission { id = 16, name = "Delete Service" });
            //permissions.Add(new Permission { id = 17, name = "Statistical" });
            //context.Permissions.AddRange(permissions);

            //Role role = new Role { id = 1, name = "Admin" };
            //Role roleCustomer = new Role { id = 2, name = "Customer" };

            //foreach (Permission permission in permissions) role.Permissions.Add(permission);
            //context.Roles.Add(role);
            //context.Roles.Add(roleCustomer);

            //var account = new Account { id = 1, username = "daitoan2000@gmail.com", password = HashPassword.GetHash("admin"), status = true };
            //account.Roles.Add(role);
            //context.Accounts.Add(account);

            //List<Division> divisions = new List<Division>();
            //divisions.Add(new Division { id = 1, name = "Bộ phận quản trị" });
            //divisions.Add(new Division { id = 2, name = "Bộ phận hành chính" });
            //divisions.Add(new Division { id = 3, name = "Bộ phận kinh doanh" });
            //divisions.Add(new Division { id = 4, name = "Bộ phận kế toán" });
            //divisions.Add(new Division { id = 5, name = "Bộ phận kỹ thuật" });
            //divisions.Add(new Division { id = 6, name = "Bộ phận marketing" }); //division_name
            //context.Divisions.AddRange(divisions);

            //List<Position> positions = new List<Position>();
            //positions.Add(new Position { id = 1, name = "Giám đốc" });
            //positions.Add(new Position { id = 2, name = "Trợ lý giám đốc" });
            //positions.Add(new Position { id = 3, name = "Quản lý" });
            //positions.Add(new Position { id = 4, name = "Chuyên viên" });
            //positions.Add(new Position { id = 5, name = "Nhân viên" });
            //positions.Add(new Position { id = 6, name = "Hướng dẫn viên" });
            //context.Positions.AddRange(positions);

            //List<Education_degree> education_Degrees = new List<Education_degree>();
            //education_Degrees.Add(new Education_degree { id = 1, name = "Phổ thông" });
            //education_Degrees.Add(new Education_degree { id = 2, name = "Trung cấp" });
            //education_Degrees.Add(new Education_degree { id = 3, name = "Đại học" });
            //education_Degrees.Add(new Education_degree { id = 4, name = "Thạc sĩ" });
            //education_Degrees.Add(new Education_degree { id = 5, name = "Tiến sĩ" });
            //education_Degrees.Add(new Education_degree { id = 6, name = "Giáo sư" });
            //context.Education_degrees.AddRange(education_Degrees);

            //var employee = new Employee
            //{
            //    id = 1,
            //    name = "Nguyễn Phước Đại Toàn",
            //    birthday = new DateTime(2002, 10, 10),
            //    gender = true,
            //    address = "Đà Nẵng",
            //    email = "daitoan2000@gmail.com",
            //    idCard = "201857426123",
            //    phone = "0967492536",
            //    salary = 9999,
            //    division_id = 1,
            //    position_id = 1,
            //    education_degree_id = 3,
            //    account_id = 1
            //};
            //context.Employees.Add(employee);
            //context.SaveChanges();

            //// Customer Type
            //List<CustomerType> customerTypes = new List<CustomerType>();
            //customerTypes.Add(new CustomerType { id = 1, name = "Standard" });
            //customerTypes.Add(new CustomerType { id = 2, name = "Silver" });
            //customerTypes.Add(new CustomerType { id = 3, name = "Gold" });
            //customerTypes.Add(new CustomerType { id = 4, name = "Platinum" });
            //customerTypes.Add(new CustomerType { id = 5, name = "Diamond" });
            //context.CustomerTypes.AddRange(customerTypes);
            //context.SaveChanges();

            ////Hotel Type
            //List<HotelType> hotelTypes = new List<HotelType>();
            //hotelTypes.Add(new HotelType { id = 1, name = "1 sao" });
            //hotelTypes.Add(new HotelType { id = 2, name = "2 sao" });
            //hotelTypes.Add(new HotelType { id = 3, name = "3 sao" });
            //hotelTypes.Add(new HotelType { id = 4, name = "4 sao" });
            //hotelTypes.Add(new HotelType { id = 5, name = "5 sao" });
            //context.HotelTypes.AddRange(hotelTypes);
            //context.SaveChanges();
        }
    }
}
