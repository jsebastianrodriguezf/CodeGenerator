using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class AlqDetallealquilerItemdocumentoConfiguration : IEntityTypeConfiguration<AlqDetallealquilerItemdocumento>
{
    public void Configure(EntityTypeBuilder<AlqDetallealquilerItemdocumento> builder)
    {
        builder.ToTable("alq_detallealquiler_itemdocumento");

        builder.HasIndex(e => e.Eid, "IX_alq_detallealquiler_itemdocumento");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DetallealquilerItemdocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detallealquiler_itemdocumento");
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
        builder.Property(e => e.IdDetallealquiler).HasColumnName("id_detallealquiler");
        builder.Property(e => e.IdItemdocumento).HasColumnName("id_itemdocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdDetallealquilerNavigation).WithMany(p => p.AlqDetallealquilerItemdocumentos)
            .HasForeignKey(d => d.IdDetallealquiler)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_alq_detallealquiler_id_detallealquiler");

        builder.HasOne(d => d.IdItemdocumentoNavigation).WithMany(p => p.AlqDetallealquilerItemdocumentos)
            .HasForeignKey(d => d.IdItemdocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_alq_detallealquiler_id_itemDocumento");
    }
}
