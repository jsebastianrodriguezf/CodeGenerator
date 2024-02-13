using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewComComisionConfiguration : IEntityTypeConfiguration<ViewComComision>
{
    public void Configure(EntityTypeBuilder<ViewComComision> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_com_comision");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatSubTipoCatalogoIdTipoCatalogo).HasColumnName("cat_subTipoCatalogo_id_tipoCatalogo");
        builder.Property(e => e.CatSubTipoCatalogoSubTipoCatalogo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_subTipoCatalogo_subTipoCatalogo");
        builder.Property(e => e.CatSubTipoCatalogoSubTipoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_subTipoCatalogo_subTipoCatalogo_codigo");
        builder.Property(e => e.Comision)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("comision");
        builder.Property(e => e.ComisionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("comision_codigo");
        builder.Property(e => e.Costear).HasColumnName("costear");
        builder.Property(e => e.DescuentoMaximo).HasColumnName("descuentoMaximo");
        builder.Property(e => e.DescuentoMinimo).HasColumnName("descuentoMinimo");
        builder.Property(e => e.DocCondicionCondicion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_condicion_condicion");
        builder.Property(e => e.DocCondicionCondicionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_condicion_condicion_codigo");
        builder.Property(e => e.DocCondicionTextoLibre).HasColumnName("doc_condicion_textoLibre");
        builder.Property(e => e.DocOpcionCondicionIdCondicion).HasColumnName("doc_opcionCondicion_id_condicion");
        builder.Property(e => e.DocOpcionCondicionOpcionCondicion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_opcionCondicion_opcionCondicion");
        builder.Property(e => e.DocOpcionCondicionOpcionCondicionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_opcionCondicion_opcionCondicion_codigo");
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
        builder.Property(e => e.IdCargo).HasColumnName("id_cargo");
        builder.Property(e => e.IdCondicion).HasColumnName("id_condicion");
        builder.Property(e => e.IdOpcionCondicion).HasColumnName("id_opcionCondicion");
        builder.Property(e => e.IdSubTipoCatalogo).HasColumnName("id_subTipoCatalogo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Nivelnegocio).HasColumnName("nivelnegocio");
        builder.Property(e => e.PorcComision).HasColumnName("porc_comision");
        builder.Property(e => e.SegCargoCargo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_cargo_cargo");
        builder.Property(e => e.SegCargoCargoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_cargo_cargo_codigo");
        builder.Property(e => e.SegCargoEsAdministrativo).HasColumnName("seg_cargo_esAdministrativo");
        builder.Property(e => e.SegCargoEsComercial).HasColumnName("seg_cargo_esComercial");
        builder.Property(e => e.SegCargoEsCoordinador).HasColumnName("seg_cargo_esCoordinador");
        builder.Property(e => e.SegCargoEsTecnico).HasColumnName("seg_cargo_esTecnico");
        builder.Property(e => e.SegCargoValorHora)
            .HasColumnType("money")
            .HasColumnName("seg_cargo_valorHora");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
