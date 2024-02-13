using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewSegCargoEnvioCorreoConfiguration : IEntityTypeConfiguration<ViewSegCargoEnvioCorreo>
{
    public void Configure(EntityTypeBuilder<ViewSegCargoEnvioCorreo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_seg_cargo_envioCorreo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CargoEnvioCorreo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cargo_envioCorreo");
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
        builder.Property(e => e.GenEnvioCorreoCorreoAdicional)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasColumnName("gen_envioCorreo_correoAdicional");
        builder.Property(e => e.GenEnvioCorreoEnvioCorreo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_envioCorreo_envioCorreo");
        builder.Property(e => e.GenEnvioCorreoEnvioCorreoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_envioCorreo_envioCorreo_codigo");
        builder.Property(e => e.GenEnvioCorreoEstrategia).HasColumnName("gen_envioCorreo_estrategia");
        builder.Property(e => e.GenEnvioCorreoIdEstadoTipoDocumento).HasColumnName("gen_envioCorreo_id_estadoTipoDocumento");
        builder.Property(e => e.GenEnvioCorreoIdReporte).HasColumnName("gen_envioCorreo_id_reporte");
        builder.Property(e => e.GenEnvioCorreoIdSubtipoDocumento).HasColumnName("gen_envioCorreo_id_subtipoDocumento");
        builder.Property(e => e.GenEnvioCorreoPlantillaAdjunto)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("gen_envioCorreo_plantillaAdjunto");
        builder.Property(e => e.GenEnvioCorreoTabla)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("gen_envioCorreo_tabla");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdCargo).HasColumnName("id_cargo");
        builder.Property(e => e.IdEnvioCorreo).HasColumnName("id_envioCorreo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
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
