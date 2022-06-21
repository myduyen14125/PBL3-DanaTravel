using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RoleBLL
    {
        private static RoleBLL _Instance;

        public static RoleBLL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new RoleBLL();
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

        public DataTable GetDataTablePermission(List<Permission> permissions = null)
        {
            DataTable dt = new DataTable();
            List<Permission> all = RoleBLL.Instance.GetListPermission(null);
            dt.Columns.AddRange(new DataColumn[]
            {
                new DataColumn {ColumnName="STT", DataType = typeof(int)},
                new DataColumn {ColumnName="ID", DataType = typeof(int)},
                new DataColumn {ColumnName = "Permission", DataType = typeof(string)},
                new DataColumn {ColumnName = "Licensing", DataType = typeof(bool)}
            });

            int i = 1;
            foreach (Permission p in all)
            {
                if (permissions == null) dt.Rows.Add(i, p.id, p.name, false);
                else dt.Rows.Add(i, p.id, p.name, permissions.Contains(p));
                i++;
            }

            return dt;
        }

    }
}
