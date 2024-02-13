using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewSynSistemaIntegrarConfiguration : IEntityTypeConfiguration<ViewSynSistemaIntegrar>
{
    public void Configure(EntityTypeBuilder<ViewSynSistemaIntegrar> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_syn_sistemaIntegrar");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Clave)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("clave");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EstructuraResponseAutenticar)
            .IsUnicode(false)
            .HasColumnName("estructuraResponseAutenticar");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdTipoAutenticacion).HasColumnName("id_tipoAutenticacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.MetodoAutenticar)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("metodoAutenticar");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.SistemaIntegrar)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("sistemaIntegrar");
        builder.Property(e => e.SistemaIntegrarCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("sistemaIntegrar_codigo");
        builder.Property(e => e.SynTipoAutenticacionTipoAutenticacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("syn_tipoAutenticacion_tipoAutenticacion");
        builder.Property(e => e.SynTipoAutenticacionTipoAutenticacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("syn_tipoAutenticacion_tipoAutenticacion_codigo");
        builder.Property(e => e.Token)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("token");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.UrlAutenticar)
            .HasMaxLength(800)
            .IsUnicode(false)
            .HasColumnName("urlAutenticar");
        builder.Property(e => e.Usuario)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("usuario");
    }
}
