using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewTerTerceroConfiguration : IEntityTypeConfiguration<ViewTerTercero>
{
    public void Configure(EntityTypeBuilder<ViewTerTercero> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_ter_tercero");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Clasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("clasificacion");
        builder.Property(e => e.Contacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("contacto");
        builder.Property(e => e.Direccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("direccion");
        builder.Property(e => e.DocFormaPagoDiasPago).HasColumnName("doc_formaPago_diasPago");
        builder.Property(e => e.DocFormaPagoFormaPago)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_formaPago_formaPago");
        builder.Property(e => e.DocFormaPagoFormaPagoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_formaPago_formaPago_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("email");
        builder.Property(e => e.EsCliente).HasColumnName("esCliente");
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
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenZonaCodigoExterno)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("gen_zona_codigoExterno");
        builder.Property(e => e.GenZonaIdZona).HasColumnName("gen_zona_id_zona");
        builder.Property(e => e.GenZonaNivel).HasColumnName("gen_zona_nivel");
        builder.Property(e => e.GenZonaTiempoDesplazamiento).HasColumnName("gen_zona_tiempoDesplazamiento");
        builder.Property(e => e.GenZonaZona)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_zona_zona");
        builder.Property(e => e.GenZonaZonaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_zona_zona_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdEstadoTercero).HasColumnName("id_estadoTercero");
        builder.Property(e => e.IdFormaPago).HasColumnName("id_formaPago");
        builder.Property(e => e.IdNaturalezaTercero).HasColumnName("id_naturalezaTercero");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
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
            .HasColumnName("telefono");
        builder.Property(e => e.TerEstadoTerceroEstadoTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_estadoTercero_estadoTercero");
        builder.Property(e => e.TerEstadoTerceroEstadoTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_estadoTercero_estadoTercero_codigo");
        builder.Property(e => e.TerNaturalezaTerceroNaturalezaTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_naturalezaTercero_naturalezaTercero");
        builder.Property(e => e.TerNaturalezaTerceroNaturalezaTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_naturalezaTercero_naturalezaTercero_codigo");
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
            .HasColumnName("tercero_nit");
        builder.Property(e => e.TerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
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
    }
}
