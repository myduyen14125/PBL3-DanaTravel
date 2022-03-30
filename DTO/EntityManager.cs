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
            private set { }
        }
        public EntityManager()
            : base("EntityManager")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
    }


}