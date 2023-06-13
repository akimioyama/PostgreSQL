using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQL.Domain
{
    public class Role
    {
        [Key]
        public int role_id { get; set; }
        public string role_name { get; set; }
        public bool change_events { get; set; }
        public bool change_user { get; set; }
        public bool read_events { get; set; }
        public bool commentder_events { get; set; }

        public virtual ICollection<User> users { get; set;}
    }
}