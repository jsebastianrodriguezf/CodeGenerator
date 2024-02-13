using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquPagoAlquilerConfiguration : IEntityTypeConfiguration<EquPagoAlquiler>
{
    public void Configure(EntityTypeBuilder<EquPagoAlquiler> builder)
    {
        builder.ToTable("equ_pagoAlquiler");

        builder.HasIndex(e => e.Eid, "IX_equ_pagoAlquiler");

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
        builder.Property(e => e.FechaEsperadaPagoFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaEsperadaPago_ff");
        builder.Property(e => e.FechaFacturaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_factura_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdDocumentoAlquiler).HasColumnName("id_documento.alquiler");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.NumeroFactura)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("numeroFactura");
        builder.Property(e => e.PagoAlquiler)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pagoAlquiler");
        builder.Property(e => e.PagoAlquilerCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pagoAlquiler_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorFacturado)
            .HasColumnType("money")
            .HasColumnName("valorFacturado");
        builder.Property(e => e.ValorPorCobrar)
            .HasColumnType("money")
            .HasColumnName("valorPorCobrar");

        builder.HasOne(d => d.IdDocumentoAlquilerNavigation).WithMany(p => p.EquPagoAlquilers)
            .HasForeignKey(d => d.IdDocumentoAlquiler)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_pagoAlquiler_id_documento_alquiler");
    }
}
