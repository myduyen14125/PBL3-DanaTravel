using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {
        public string username { get; set; }
        public string password { get; set; }
        public bool status { get; set; }
        public int role_id { get; set; }
        public string role_name { get; set; }

        public List<int> permission_ids { get; set; }
        public List<String> permission_names { get; set; }

        public AccountDTO() { }

        public AccountDTO(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public AccountDTO(string username, string password, bool status, int role_id, string role_name) : this(username, password)
        {
            this.status = status;
            this.role_id = role_id;
            this.role_name = role_name;
        }

        public AccountDTO(string username, string password, bool status, int role_id, string role_name, List<int> permission_ids, List<string> permission_names) : this(username, password, status, role_id, role_name)
        {
            this.permission_ids = permission_ids;
            this.permission_names = permission_names;
        }
    }
}
