using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<Permission> Permissions { get; set; }

        public Role()
        {
            Accounts = new List<Account>();
            Permissions = new List<Permission>();
        }
    }
}
