using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UsuariosAPP.Domain.Entities;

namespace UsuariosApp.Infra.Data.Mappings
{
    /// <summary>
    /// Classe de mapeamento ORM para perfil
    /// </summary>
    public class PerfilMap : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            //mapeamento da tabela
            builder.ToTable("PERFIL");

            //cahve primária
            builder.HasKey(p => p.Id);

            //mapeamento dos campos
            builder.Property(p => p.Id).HasColumnName("ID");
            builder.Property(p => p.Nome).HasColumnName("NOME").HasMaxLength(50).IsRequired();
            builder.HasIndex(p => p.Nome).IsUnique();
        }
    }
}
