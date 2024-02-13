using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenRemitenteCorreoConfiguration : IEntityTypeConfiguration<ViewGenRemitenteCorreo>
{
    public void Configure(EntityTypeBuilder<ViewGenRemitenteCorreo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_remitenteCorreo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.ArchivoCertificado)
            .HasMaxLength(800)
            .IsUnicode(false)
            .HasColumnName("archivoCertificado");
        builder.Property(e => e.Certificado).HasColumnName("certificado");
        builder.Property(e => e.Credenciales)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("credenciales");
        builder.Property(e => e.CuentaCertificado)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("cuentaCertificado");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsGsuite).HasColumnName("esGSuite");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Puerto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("puerto");
        builder.Property(e => e.RemitenteCorreo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("remitenteCorreo");
        builder.Property(e => e.RemitenteCorreoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("remitenteCorreo_codigo");
        builder.Property(e => e.Servidor)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("servidor");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
