using Katman.DAL;
using Katman.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katman.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //User user = new User();
            //user.UserName = "Yavuz Gedik";
            //Repository.UserAdd(user);

            var result = Repository.GetAllUser();

            foreach (var item in result)
            {
                System.Console.WriteLine(item.UserName);
            }

            System.Console.ReadKey();
        }
    }
}
