using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ProHitoConfiguration : IEntityTypeConfiguration<ProHito>
{
    public void Configure(EntityTypeBuilder<ProHito> builder)
    {
        builder.ToTable("pro_hito");

        builder.HasIndex(e => e.Eid, "IX_pro_hito");

        builder.Property(e => e.Id).HasColumnName("id");
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
        builder.Property(e => e.Hito)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("hito");
        builder.Property(e => e.HitoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("hito_codigo");
        builder.Property(e => e.IdDocumentoProyecto).HasColumnName("id_documento.proyecto");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdDocumentoProyectoNavigation).WithMany(p => p.ProHitos)
            .HasForeignKey(d => d.IdDocumentoProyecto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_pro_hito_id_documento.proyecto");
    }
}
