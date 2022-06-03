using DTO.CodeFirstDB;
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

        // rent table in database
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Education_degree> Education_degrees { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerType> CustomerTypes { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<TourCategory> TourCategories { get; set; }
        public virtual DbSet<TourStatus> TourStatuses { get; set; }
        public virtual DbSet<TourImage> TourImages { get; set; }
        public virtual DbSet<TourTicket> TourTickets { get; set; }
        public virtual DbSet<TourTicketStatus> TourTicketStatuses { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }
        public virtual DbSet<BillStatus> BillStatuses { get; set; }
        public virtual DbSet<Statistic> Statistics { get; set; }
    }
}