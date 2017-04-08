using Katman.Entity.DBContext;
using Katman.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katman.DAL
{
    public class Repository
    {
        public static void UserAdd(User user)
        {
            using (UserDBContext db = new UserDBContext())
            {
                db.User.Add(user);
                db.SaveChanges();
            }
        }

        public static List<User> GetAllUser()
        {
            using (UserDBContext db = new UserDBContext())
            {
                return db.User.ToList();
            }
        }

        public static void DeleteUser(int id)
        {
            using (UserDBContext db = new UserDBContext())
            {
                var result = db.User.FirstOrDefault(u => u.UserId == id);
                db.User.Remove(result);
                db.SaveChanges();
            }
        }
    }
}
