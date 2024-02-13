using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquAlquilerConfiguration : IEntityTypeConfiguration<EquAlquiler>
{
    public void Configure(EntityTypeBuilder<EquAlquiler> builder)
    {
        builder.ToTable("equ_alquiler");

        builder.HasIndex(e => e.Eid, "IX_equ_alquiler");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Alquiler)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("alquiler");
        builder.Property(e => e.AlquilerCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("alquiler_codigo");
        builder.Property(e => e.AlquilerNumero).HasColumnName("alquiler_numero");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCompromisoFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCompromiso_ff");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFinFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFin_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.MesVencido)
            .HasDefaultValue(true)
            .HasColumnName("mesVencido");
        builder.Property(e => e.Observaciones)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("observaciones");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.EquAlquilers)
            .HasForeignKey(d => d.IdDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_alquiler_doc_documento");

        builder.HasOne(d => d.IdSubtipoDocumentoNavigation).WithMany(p => p.EquAlquilers)
            .HasForeignKey(d => d.IdSubtipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_alquiler_id_subtipoDocumento");

        builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.EquAlquilers)
            .HasForeignKey(d => d.IdSucursal)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_alquiler_id_sucursal");

        builder.HasOne(d => d.IdTerceroNavigation).WithMany(p => p.EquAlquilers)
            .HasForeignKey(d => d.IdTercero)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_alquiler_id_tercero");
    }
}
