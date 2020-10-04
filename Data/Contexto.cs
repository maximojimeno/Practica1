using Microsoft.EntityFrameworkCore;
using  Practica1.Models;
namespace Practica1.Data
{
    public class Contexto : DbContext
    {
        public  DbSet<Productos> Productos{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source = Data\\Registro.db");


        }
    }
}