using Microsoft.EntityFrameworkCore;
using UsuariosApp.Infra.Data.Mappings;

namespace UsuariosAPP.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        /// <summary>
        /// Método para conectar ao BD
        /// </summary>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BDUsuariosAPP;Integrated Security=True;");
        }

        /// <summary>
        /// Método para adicionar as classes de mapeamento ORM do projeto
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new PerfilMap());
        }
    }
}
