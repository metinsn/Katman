namespace Katman.Entity.DBContext
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UserDBContext : DbContext
    {
        public UserDBContext()
            : base("name=UserDB")
        {
        }

        public virtual DbSet<User> User { get; set; }
    }
}