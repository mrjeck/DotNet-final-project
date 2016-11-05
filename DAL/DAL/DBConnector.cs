using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public static class DBConnector
    {
        public static bool CheckVisitor(string _username, string _password)
        {
            using (BaseContext db = new BaseContext())
            {
                var resault = (from c in db.Clients
                               where c.Username == _username && c.Password == _password
                               select c).Any();
                return resault;
            }
        }

        public static void Add_visitor(string _username, string _password)
        {
            using (BaseContext db = new BaseContext())
            {
                Client new_visitor = new Client()
                {
                   Username = _username,
                    Password = _password 
                };
                db.Clients.Add(new_visitor);
                db.SaveChanges();
            }
        }
    }
}
