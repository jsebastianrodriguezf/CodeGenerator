using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class TerTerceroConfiguration : IEntityTypeConfiguration<TerTercero>
{
    public void Configure(EntityTypeBuilder<TerTercero> builder)
    {
        builder.ToTable("ter_tercero");

        builder.HasIndex(e => e.Eid, "IX_ter_tercero");

        builder.HasIndex(e => e.TerceroNit, "IX_ter_tercero_tercero_nit");

        builder.HasIndex(e => e.TerceroNombreCorto, "IX_ter_tercero_tercero_nombreCorto");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Clasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("clasificacion");
        builder.Property(e => e.Contacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("contacto");
        builder.Property(e => e.Direccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("direccion");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("email");
        builder.Property(e => e.EsCliente)
            .HasDefaultValue(true)
            .HasColumnName("esCliente");
        builder.Property(e => e.EsEmpresaPropia).HasColumnName("esEmpresaPropia");
        builder.Property(e => e.EsFabricante).HasColumnName("esFabricante");
        builder.Property(e => e.EsProspecto).HasColumnName("esProspecto");
        builder.Property(e => e.EsProveedor).HasColumnName("esProveedor");
        builder.Property(e => e.EsTransportador).HasColumnName("esTransportador");
        builder.Property(e => e.Fax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("fax");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdEstadoTercero).HasColumnName("id_estadoTercero");
        builder.Property(e => e.IdFormaPago)
            .HasDefaultValue(0)
            .HasColumnName("id_formaPago");
        builder.Property(e => e.IdNaturalezaTercero).HasColumnName("id_naturalezaTercero");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.Notas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("notas");
        builder.Property(e => e.Representante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("representante");
        builder.Property(e => e.Telefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("telefono");
        builder.Property(e => e.Tercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tercero");
        builder.Property(e => e.TerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tercero_codigo");
        builder.Property(e => e.TerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("tercero_nit");
        builder.Property(e => e.TerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("tercero_nombreCorto");
        builder.Property(e => e.TiempoEntrega).HasColumnName("tiempoEntrega");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Website)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("website");

        builder.HasOne(d => d.IdEstadoTerceroNavigation).WithMany(p => p.TerTerceros)
            .HasForeignKey(d => d.IdEstadoTercero)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_tercero_id_estadoTercero");

        builder.HasOne(d => d.IdFormaPagoNavigation).WithMany(p => p.TerTerceros)
            .HasForeignKey(d => d.IdFormaPago)
            .HasConstraintName("FK__ter_terce__id_fo__698B7EDD");

        builder.HasOne(d => d.IdNaturalezaTerceroNavigation).WithMany(p => p.TerTerceros)
            .HasForeignKey(d => d.IdNaturalezaTercero)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_tercero_id_naturalezaTercero");

        builder.HasOne(d => d.IdZonaNavigation).WithMany(p => p.TerTerceros)
            .HasForeignKey(d => d.IdZona)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_tercero_id_zona");
    }
}
