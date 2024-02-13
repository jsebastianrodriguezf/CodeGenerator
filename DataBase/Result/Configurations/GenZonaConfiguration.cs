using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenZonaConfiguration : IEntityTypeConfiguration<GenZona>
{
    public void Configure(EntityTypeBuilder<GenZona> builder)
    {
        builder.ToTable("gen_zona");

        builder.HasIndex(e => e.Eid, "IX_gen_zona");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CodigoExterno)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("codigoExterno");
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
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.Nivel).HasColumnName("nivel");
        builder.Property(e => e.TiempoDesplazamiento).HasColumnName("tiempoDesplazamiento");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Zona)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("zona");
        builder.Property(e => e.ZonaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("zona_codigo");

        builder.HasOne(d => d.IdZonaNavigation).WithMany(p => p.InverseIdZonaNavigation)
            .HasForeignKey(d => d.IdZona)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_zona_id_zona");
    }
}
