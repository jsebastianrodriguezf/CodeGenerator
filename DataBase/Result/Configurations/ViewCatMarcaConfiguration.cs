using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatMarcaConfiguration : IEntityTypeConfiguration<ViewCatMarca>
{
    public void Configure(EntityTypeBuilder<ViewCatMarca> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_marca");

        builder.Property(e => e.Active).HasColumnName("active");
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
        builder.Property(e => e.IdTerceroFabricante).HasColumnName("id_tercero_fabricante");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Marca)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("marca");
        builder.Property(e => e.MarcaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("marca_codigo");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.TerTerceroFabricanteClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fabricante_clasificacion");
        builder.Property(e => e.TerTerceroFabricanteContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fabricante_contacto");
        builder.Property(e => e.TerTerceroFabricanteDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fabricante_direccion");
        builder.Property(e => e.TerTerceroFabricanteEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fabricante_email");
        builder.Property(e => e.TerTerceroFabricanteEsCliente).HasColumnName("ter_tercero_fabricante_esCliente");
        builder.Property(e => e.TerTerceroFabricanteEsEmpresaPropia).HasColumnName("ter_tercero_fabricante_esEmpresaPropia");
        builder.Property(e => e.TerTerceroFabricanteEsFabricante).HasColumnName("ter_tercero_fabricante_esFabricante");
        builder.Property(e => e.TerTerceroFabricanteEsProspecto).HasColumnName("ter_tercero_fabricante_esProspecto");
        builder.Property(e => e.TerTerceroFabricanteEsProveedor).HasColumnName("ter_tercero_fabricante_esProveedor");
        builder.Property(e => e.TerTerceroFabricanteEsTransportador).HasColumnName("ter_tercero_fabricante_esTransportador");
        builder.Property(e => e.TerTerceroFabricanteFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fabricante_fax");
        builder.Property(e => e.TerTerceroFabricanteIdEstadoTercero).HasColumnName("ter_tercero_fabricante_id_estadoTercero");
        builder.Property(e => e.TerTerceroFabricanteIdNaturalezaTercero).HasColumnName("ter_tercero_fabricante_id_naturalezaTercero");
        builder.Property(e => e.TerTerceroFabricanteIdZona).HasColumnName("ter_tercero_fabricante_id_zona");
        builder.Property(e => e.TerTerceroFabricanteNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fabricante_notas");
        builder.Property(e => e.TerTerceroFabricanteRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fabricante_representante");
        builder.Property(e => e.TerTerceroFabricanteTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fabricante_telefono");
        builder.Property(e => e.TerTerceroFabricanteTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fabricante_tercero");
        builder.Property(e => e.TerTerceroFabricanteTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fabricante_tercero_codigo");
        builder.Property(e => e.TerTerceroFabricanteTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fabricante_tercero_nit");
        builder.Property(e => e.TerTerceroFabricanteTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fabricante_tercero_nombreCorto");
        builder.Property(e => e.TerTerceroFabricanteWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fabricante_website");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
