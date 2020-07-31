
using Microsoft.EntityFrameworkCore;

using Noahtech.Models;

namespace NoahTech.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            InicializaBD.Initialize(this);
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<FaleConosco>FaleConosco  { get; set; }



    }
}
