using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.UserDal;
using Entity;

namespace Dal.Context
{
    public class UsersContex : DbContext
    {
        public UsersContex() : base("Users")
        {
            Database.Connection.ConnectionString = "Server = DESKTOP-7DAI8NE\\MSSQLSERVER01; Database = Login; Trusted_Connection = True;";
        }

        public DbSet<UserInfo> UserInfos { get; set; }

        protected void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsersInfoDal());


            base.OnModelCreating(modelBuilder);
        }
    }
}
