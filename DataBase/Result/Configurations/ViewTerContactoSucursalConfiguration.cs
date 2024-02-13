using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewTerContactoSucursalConfiguration : IEntityTypeConfiguration<ViewTerContactoSucursal>
{
    public void Configure(EntityTypeBuilder<ViewTerContactoSucursal> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_ter_contacto_sucursal");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.ContactoSucursal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("contacto_sucursal");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdContacto).HasColumnName("id_contacto");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.TerContactoAccesoActivo).HasColumnName("ter_contacto_accesoActivo");
        builder.Property(e => e.TerContactoCargo)
            .HasMaxLength(100)
            .HasColumnName("ter_contacto_cargo");
        builder.Property(e => e.TerContactoCodigoAcceso)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_codigoAcceso");
        builder.Property(e => e.TerContactoContacto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_contacto");
        builder.Property(e => e.TerContactoContactoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_contacto_codigo");
        builder.Property(e => e.TerContactoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_Direccion");
        builder.Property(e => e.TerContactoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_Email");
        builder.Property(e => e.TerContactoFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_Fax");
        builder.Property(e => e.TerContactoIdCargoContacto).HasColumnName("ter_contacto_id_cargoContacto");
        builder.Property(e => e.TerContactoIdTercero).HasColumnName("ter_contacto_id_tercero");
        builder.Property(e => e.TerContactoIdUsuario).HasColumnName("ter_contacto_id_usuario");
        builder.Property(e => e.TerContactoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_telefono");
        builder.Property(e => e.TerContactoTelefonoMovil)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_telefonoMovil");
        builder.Property(e => e.TerSucursalCodigorecursiva)
            .HasMaxLength(5000)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_codigorecursiva");
        builder.Property(e => e.TerSucursalContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_contacto");
        builder.Property(e => e.TerSucursalDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Direccion");
        builder.Property(e => e.TerSucursalEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Email");
        builder.Property(e => e.TerSucursalFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Fax");
        builder.Property(e => e.TerSucursalIdEstadoTercero).HasColumnName("ter_sucursal_id_estadoTercero");
        builder.Property(e => e.TerSucursalIdSucursal).HasColumnName("ter_sucursal_id_sucursal");
        builder.Property(e => e.TerSucursalIdTercero).HasColumnName("ter_sucursal_id_tercero");
        builder.Property(e => e.TerSucursalIdUsuarioAsesor).HasColumnName("ter_sucursal_id_usuario_asesor");
        builder.Property(e => e.TerSucursalIdUsuarioTecnico).HasColumnName("ter_sucursal_id_usuario_tecnico");
        builder.Property(e => e.TerSucursalIdZona).HasColumnName("ter_sucursal_id_zona");
        builder.Property(e => e.TerSucursalParaAlquiler).HasColumnName("ter_sucursal_paraAlquiler");
        builder.Property(e => e.TerSucursalParaSoporte).HasColumnName("ter_sucursal_paraSoporte");
        builder.Property(e => e.TerSucursalParaVenta).HasColumnName("ter_sucursal_paraVenta");
        builder.Property(e => e.TerSucursalSucursal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_sucursal");
        builder.Property(e => e.TerSucursalSucursalCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_sucursal_codigo");
        builder.Property(e => e.TerSucursalTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_telefono");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
