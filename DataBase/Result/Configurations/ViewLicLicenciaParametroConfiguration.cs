using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewLicLicenciaParametroConfiguration : IEntityTypeConfiguration<ViewLicLicenciaParametro>
{
    public void Configure(EntityTypeBuilder<ViewLicLicenciaParametro> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_lic_licencia_parametro");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsParteSerial).HasColumnName("esParteSerial");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdLicencia).HasColumnName("id_licencia");
        builder.Property(e => e.IdParametro).HasColumnName("id_parametro");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.LicLicenciaClave)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("lic_licencia_clave");
        builder.Property(e => e.LicLicenciaFechaFinFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("lic_licencia_fechaFin_ff");
        builder.Property(e => e.LicLicenciaFechaInicioFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("lic_licencia_fechaInicio_ff");
        builder.Property(e => e.LicLicenciaIdCatalogo).HasColumnName("lic_licencia_id_catalogo");
        builder.Property(e => e.LicLicenciaIdTercero).HasColumnName("lic_licencia_id_tercero");
        builder.Property(e => e.LicLicenciaLicencia)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("lic_licencia_licencia");
        builder.Property(e => e.LicLicenciaLicenciaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("lic_licencia_licencia_codigo");
        builder.Property(e => e.LicLicenciaSerial)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("lic_licencia_serial");
        builder.Property(e => e.LicParametroDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("lic_parametro_descripcion");
        builder.Property(e => e.LicParametroParametro)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("lic_parametro_parametro");
        builder.Property(e => e.LicParametroParametroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("lic_parametro_parametro_codigo");
        builder.Property(e => e.LicenciaParametro)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("licencia_parametro");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Valor)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("valor");
    }
}
