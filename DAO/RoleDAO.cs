using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class RoleDAO
    {
        private static RoleDAO _Instance;

        public static RoleDAO Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new RoleDAO();
                }
                return _Instance;
            }
        }

        public List<string> GetListRoleName()
        {
            return EntityManager.Instance.Roles.Select(e => e.name).ToList();
        }

        public Role GetRoleByName(string roleName)
        {
            return EntityManager.Instance.Roles.Where(r => r.name == roleName).FirstOrDefault();
        }
        public List<Permission> GetListPermission(List<string> roleNames)
        {
            if (roleNames == null)
                return EntityManager.Instance.Permissions.ToList();
            
            return EntityManager.Instance.Permissions.Where(item => item.Roles.Any(r => roleNames.Contains(r.name))).ToList();
        }

        public Permission GetPermissionById(int id)
        {
            return EntityManager.Instance.Permissions.Where(p => p.id == id).FirstOrDefault();
        }


        public void Add(Role role)
        {
            EntityManager db = EntityManager.Instance;
            db.Roles.Add(role);
            db.SaveChanges();
        }
    }
}
