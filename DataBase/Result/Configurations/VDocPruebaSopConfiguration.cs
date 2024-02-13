using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class VDocPruebaSopConfiguration : IEntityTypeConfiguration<VDocPruebaSop>
{
    public void Configure(EntityTypeBuilder<VDocPruebaSop> builder)
    {
        builder
            .HasNoKey()
            .ToView("v_doc_prueba_sop");

        builder.Property(e => e.Cuerpo)
            .HasMaxLength(47)
            .IsUnicode(false)
            .HasColumnName("CUERPO");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("id");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
    }
}
