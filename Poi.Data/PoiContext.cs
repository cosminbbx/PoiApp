using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Poi.Data
{
    public class PoiContext: DbContext
    {
        public DbSet<PointOfInterest> Pois { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=Sem6;Trusted_Connection=True;");
            }
        }
    }
}
