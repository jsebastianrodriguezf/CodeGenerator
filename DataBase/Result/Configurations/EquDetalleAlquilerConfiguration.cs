using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquDetalleAlquilerConfiguration : IEntityTypeConfiguration<EquDetalleAlquiler>
{
    public void Configure(EntityTypeBuilder<EquDetalleAlquiler> builder)
    {
        builder.ToTable("equ_detalleAlquiler");

        builder.HasIndex(e => e.Eid, "IX_equ_detalleAlquiler");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.BloquearDespacho).HasColumnName("bloquearDespacho");
        builder.Property(e => e.CantidadAlquilada).HasColumnName("cantidadAlquilada");
        builder.Property(e => e.CantidadSolicitada).HasColumnName("cantidadSolicitada");
        builder.Property(e => e.DetalleAlquiler)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detalleAlquiler");
        builder.Property(e => e.DetalleAlquilerCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("detalleAlquiler_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsSerializado).HasColumnName("esSerializado");
        builder.Property(e => e.Estadoalquiler).HasColumnName("estadoalquiler");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaDespachoFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaDespacho_ff");
        builder.Property(e => e.FechaDevolucionFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaDevolucion_ff");
        builder.Property(e => e.FechaInicioFacturaFh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicioFactura_fh");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaUltimaFacturaFh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaUltimaFactura_fh");
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdDocumentoAlquiler).HasColumnName("id_documento.alquiler");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorHora)
            .HasColumnType("money")
            .HasColumnName("valorHora");
        builder.Property(e => e.ValorHoraStandBy).HasColumnType("money");
        builder.Property(e => e.ValorMes)
            .HasDefaultValue(0.0)
            .HasColumnName("valorMes");
        builder.Property(e => e.ValorMulta)
            .HasColumnType("money")
            .HasColumnName("valorMulta");
        builder.Property(e => e.ValorPeriodo)
            .HasColumnType("money")
            .HasColumnName("valorPeriodo");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.EquDetalleAlquilers)
            .HasForeignKey(d => d.IdCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_detalleAlquiler_id_catalogo");

        builder.HasOne(d => d.IdDocumentoAlquilerNavigation).WithMany(p => p.EquDetalleAlquilers)
            .HasForeignKey(d => d.IdDocumentoAlquiler)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_detalleAlquiler_id_documento_alquiler");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.EquDetalleAlquilers)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_detalleAlquiler_id_equipo");

        builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.EquDetalleAlquilers)
            .HasForeignKey(d => d.IdSucursal)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_detalleAlquiler_id_sucursal");

        builder.HasOne(d => d.IdTerceroNavigation).WithMany(p => p.EquDetalleAlquilers)
            .HasForeignKey(d => d.IdTercero)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_detalleAlquiler_id_tercero");
    }
}
