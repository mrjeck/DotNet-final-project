using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Messages_history
    {
        [Key]
        public int id { get; set; }
        public DateTime date { get; set; }
        public string Messages { get; set; }

        public virtual Client client { get; set; }
    }
}
