using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQL.Domain
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public int role_id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string FIO { get; set; }
    }
}