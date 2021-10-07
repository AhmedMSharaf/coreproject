using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreproject.Models
{
    public class NewContext :DbContext
    {
        public NewContext(DbContextOptions<NewContext> options)
            : base(options)
    {
    }

        public DbSet<News> News { get; set; }
        public DbSet<Categroy> Categroys { get; set; }
        public DbSet<Teammemmber> Teammemmbers { get; set; }
        public DbSet<ContactUs> contactU { get; set; }



    }
}
