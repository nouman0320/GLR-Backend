using GLR_Backend_API_NET_CORE.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GLR_Backend_API_NET_CORE
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher>  Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Leacture> Leactures { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost;Database=EntityFramework;User=root;Password=usman");
            base.OnConfiguring(optionsBuilder);
            
        }
    }
}
