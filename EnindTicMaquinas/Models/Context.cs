using Microsoft.EntityFrameworkCore;

namespace EnindTicMaquinas.Models
{
    public class Context : DbContext
    {   
        public Context(DbContextOptions<Context> options) 
            :base(options) 
        { 

        }
        public DbSet<Maquina> Maquinas { get; set; }
    }
}
