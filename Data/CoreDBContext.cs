using CoreWebApplication.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApplication.Data
{
    public class CoreDBContext
    {
        public CoreDBContext() : base("conn")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Medicine>().ToTable("Medicine");
        }
        public DbSet<Medicine> Medicine { get; set; }
    }
}
