using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenDetalleRegistroEnvioConfiguration : IEntityTypeConfiguration<ViewGenDetalleRegistroEnvio>
{
    public void Configure(EntityTypeBuilder<ViewGenDetalleRegistroEnvio> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_detalleRegistroEnvio");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DetalleRegistroEnvio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detalleRegistroEnvio");
        builder.Property(e => e.DetalleRegistroEnvioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("detalleRegistroEnvio_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Email)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("email");
        builder.Property(e => e.Enviado).HasColumnName("enviado");
        builder.Property(e => e.Enviar).HasColumnName("enviar");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenRegistroEnvioIdEnvioCorreo).HasColumnName("gen_registroEnvio_id_envioCorreo");
        builder.Property(e => e.GenRegistroEnvioIdRegistroEnvio).HasColumnName("gen_registroEnvio_id_registroEnvio");
        builder.Property(e => e.GenRegistroEnvioRegistroEnvio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_registroEnvio_registroEnvio");
        builder.Property(e => e.GenRegistroEnvioRegistroEnvioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_registroEnvio_registroEnvio_codigo");
        builder.Property(e => e.GenRegistroEnvioReintentar).HasColumnName("gen_registroEnvio_reintentar");
        builder.Property(e => e.GenRegistroEnvioTabla)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("gen_registroEnvio_tabla");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdObjeto).HasColumnName("idObjeto");
        builder.Property(e => e.IdRegistroEnvio).HasColumnName("id_registroEnvio");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
