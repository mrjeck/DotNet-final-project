using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Client
    {
        [Key]
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual List<Messages_history> messages_history { get; set; }

        public Client()
        {
            messages_history = new List<Messages_history>();
        }
    }
}
