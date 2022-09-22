using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller.App.Domain;

namespace Taller.App.Persistencia
{   
    
    public class ContextBd : DbContext
    {
        public DbSet<Mecanico> Mecanicos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured) {

            optionsBuilder.UseSqlServer("Server=tcp:database-mintic.database.windows.net,1433;Initial Catalog=bd_mintic;Persist Security Info=False;User ID=grupo-5;Password=0Codercrew 4580;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
        }
    }
    }
    
}