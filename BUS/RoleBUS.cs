using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class RoleBUS
    {
        private static RoleBUS _Instance;

        public static RoleBUS Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new RoleBUS();
                }
                return _Instance;
            }
        }

        public List<string> GetListRoleName()
        {
            return RoleDAO.Instance.GetListRoleName();
        }

        public Role GetRoleByName(string roleName)
        {
            return RoleDAO.Instance.GetRoleByName(roleName);
        }

        public List<Permission> GetListPermission(List<string> roleNames)
        {
            return RoleDAO.Instance.GetListPermission(roleNames);
        }


        public Permission GetPermissionById(int id)
        {
            return RoleDAO.Instance.GetPermissionById(id);
        }

        public void Add(Role role)
        {
            RoleDAO.Instance.Add(role);
        }

        public DataTable GetDataTablePermission(List<Permission> permissions = null)
        {
            DataTable dt = new DataTable();
            List<Permission> all = RoleBUS.Instance.GetListPermission(null);
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
