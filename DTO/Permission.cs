using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Permission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? per_id { get; set; }

        [Required]
        public string per_name { get; set; }
        public virtual ICollection<Role> Roles { get; set; }

        public Permission()
        {
            Roles = new List<Role>();
        }
    }

}
