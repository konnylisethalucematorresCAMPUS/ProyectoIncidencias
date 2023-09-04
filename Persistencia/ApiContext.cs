using System.Reflection;
using Dominio;

using Microsoft.EntityFrameworkCore;


namespace Persistencia
{
    public class ApiContext : DbContext
    {
        public  ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {
        }
        public DbSet<Usuario> ? Usuarios { get; set; }
        public DbSet<Rol> ? Roles { get; set;}
        public DbSet<UsuariosRoles> ? UsuariosRoles { get; set; }        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasIndex(idx => idx.Username).IsUnique();
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
    
    
}