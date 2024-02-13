using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class TerSucursalConfiguration : IEntityTypeConfiguration<TerSucursal>
{
    public void Configure(EntityTypeBuilder<TerSucursal> builder)
    {
        builder.ToTable("ter_sucursal");

        builder.HasIndex(e => e.Eid, "IX_ter_sucursal");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Cargo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("cargo");
        builder.Property(e => e.Codigorecursiva)
            .HasMaxLength(5000)
            .IsUnicode(false)
            .HasColumnName("codigorecursiva");
        builder.Property(e => e.Contacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("contacto");
        builder.Property(e => e.Direccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue("");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsUnicode(false);
        builder.Property(e => e.Fax)
            .HasMaxLength(100)
            .IsUnicode(false);
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdEstadoTercero).HasColumnName("id_estadoTercero");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdUsuarioAsesor).HasColumnName("id_usuario_asesor");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdUsuarioTecnico).HasColumnName("id_usuario_tecnico");
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.ParaAlquiler).HasColumnName("paraAlquiler");
        builder.Property(e => e.ParaSoporte).HasColumnName("paraSoporte");
        builder.Property(e => e.ParaVenta).HasColumnName("paraVenta");
        builder.Property(e => e.Sucursal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("sucursal");
        builder.Property(e => e.SucursalCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("sucursal_codigo");
        builder.Property(e => e.Telefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("telefono");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdEstadoTerceroNavigation).WithMany(p => p.TerSucursals)
            .HasForeignKey(d => d.IdEstadoTercero)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_sucursal_id_estadoTercero");

        builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.InverseIdSucursalNavigation)
            .HasForeignKey(d => d.IdSucursal)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_sucursal_id_sucursal");

        builder.HasOne(d => d.IdTerceroNavigation).WithMany(p => p.TerSucursals)
            .HasForeignKey(d => d.IdTercero)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_sucursal_id_tercero");

        builder.HasOne(d => d.IdUsuarioAsesorNavigation).WithMany(p => p.TerSucursalIdUsuarioAsesorNavigations)
            .HasForeignKey(d => d.IdUsuarioAsesor)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_sucursal_id_usuario_asesor");

        builder.HasOne(d => d.IdUsuarioTecnicoNavigation).WithMany(p => p.TerSucursalIdUsuarioTecnicoNavigations)
            .HasForeignKey(d => d.IdUsuarioTecnico)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_sucursal_id_usuario_tecnico");

        builder.HasOne(d => d.IdZonaNavigation).WithMany(p => p.TerSucursals)
            .HasForeignKey(d => d.IdZona)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_sucursal_id_zona");
    }
}
