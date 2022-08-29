using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using Entity;

namespace Dal.UserDal
{
    public class UsersInfoDal :EntityTypeConfiguration<UserInfo>
    {
        public UsersInfoDal()
        {
            ToTable("users");
            HasKey(x => x.Id);
            Property(x => x.Name).IsRequired().HasColumnName("Name");
            Property(x => x.Surname).IsRequired().HasColumnName("Surname");
            Property(x => x.Address).IsRequired().HasColumnName("Address");
        }
    }
}
