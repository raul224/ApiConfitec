using ApiConfitec.Core.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ApiConfitec.Infraestrutura
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) 
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
