using System;
using System.Data.Entity;
using System.Linq;

namespace DTO
{
    public class EntityManager : DbContext
    {
        private static EntityManager _Instance;

        public static EntityManager Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new EntityManager();
                    Database.SetInitializer<EntityManager>(new CreateDB());
                }
                return _Instance;
            }
        }
        public EntityManager()
            : base("EntityManager")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //tu tao role
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Education_degree> Education_degrees { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerType> CustomerTypes { get; set; }
        public virtual DbSet<Tour> Tour { get; set; }
    }
}