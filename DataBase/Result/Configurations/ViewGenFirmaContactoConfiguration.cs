using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenFirmaContactoConfiguration : IEntityTypeConfiguration<ViewGenFirmaContacto>
{
    public void Configure(EntityTypeBuilder<ViewGenFirmaContacto> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_firmaContacto");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Archivobinario)
            .HasColumnType("image")
            .HasColumnName("archivobinario");
        builder.Property(e => e.Codigoacceso)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("codigoacceso");
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
        builder.Property(e => e.FirmaContacto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("firmaContacto");
        builder.Property(e => e.FirmaContactoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("firmaContacto_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdContacto).HasColumnName("id_contacto");
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
            .HasMaxLength(100)
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
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
