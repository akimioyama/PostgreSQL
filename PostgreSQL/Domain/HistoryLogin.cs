using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreSQL.Domain
{
    public class HistoryLogin
    {
        [Key]
        public int Id { get; set; }
        //public int user_id { get; set; }
        public DateTimeOffset last_login_datetimeoffset { get; set; }
        public string IP { get; set; }
        public string device_settings { get; set; }
        public virtual User User { get; set; }
    }
}