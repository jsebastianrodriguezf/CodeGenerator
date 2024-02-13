using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SynTipoAutenticacionConfiguration : IEntityTypeConfiguration<SynTipoAutenticacion>
{
    public void Configure(EntityTypeBuilder<SynTipoAutenticacion> builder)
    {
        builder.ToTable("syn_tipoAutenticacion");

        builder.HasIndex(e => e.Eid, "IX_syn_tipoAutenticacion");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.TipoAutenticacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tipoAutenticacion");
        builder.Property(e => e.TipoAutenticacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tipoAutenticacion_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
