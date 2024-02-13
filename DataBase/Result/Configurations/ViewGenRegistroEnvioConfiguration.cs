using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenRegistroEnvioConfiguration : IEntityTypeConfiguration<ViewGenRegistroEnvio>
{
    public void Configure(EntityTypeBuilder<ViewGenRegistroEnvio> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_registroEnvio");

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
        builder.Property(e => e.GenEnvioCorreoCantidadMensajes).HasColumnName("gen_envioCorreo_cantidadMensajes");
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
        builder.Property(e => e.GenEnvioCorreoTiempoPorMensajes).HasColumnName("gen_envioCorreo_tiempo_por_mensajes");
        builder.Property(e => e.GenRegistroEnvioPadreIdEnvioCorreo).HasColumnName("gen_registroEnvio_padre_id_envioCorreo");
        builder.Property(e => e.GenRegistroEnvioPadreIdRegistroEnvio).HasColumnName("gen_registroEnvio_padre_id_registroEnvio");
        builder.Property(e => e.GenRegistroEnvioPadreRegistroEnvio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_registroEnvio_padre_registroEnvio");
        builder.Property(e => e.GenRegistroEnvioPadreRegistroEnvioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_registroEnvio_padre_registroEnvio_codigo");
        builder.Property(e => e.GenRegistroEnvioPadreReintentar).HasColumnName("gen_registroEnvio_padre_reintentar");
        builder.Property(e => e.GenRegistroEnvioPadreTabla)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("gen_registroEnvio_padre_tabla");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdEnvioCorreo).HasColumnName("id_envioCorreo");
        builder.Property(e => e.IdRegistroEnvio).HasColumnName("id_registroEnvio");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.RegistroEnvio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("registroEnvio");
        builder.Property(e => e.RegistroEnvioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("registroEnvio_codigo");
        builder.Property(e => e.Reintentar).HasColumnName("reintentar");
        builder.Property(e => e.Tabla)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("tabla");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
