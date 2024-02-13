using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SynSistemaIntegrarConfiguration : IEntityTypeConfiguration<SynSistemaIntegrar>
{
    public void Configure(EntityTypeBuilder<SynSistemaIntegrar> builder)
    {
        builder.ToTable("syn_sistemaIntegrar");

        builder.HasIndex(e => e.Eid, "IX_syn_sistemaIntegrar");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Clave)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("clave");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EstructuraResponseAutenticar)
            .IsUnicode(false)
            .HasColumnName("estructuraResponseAutenticar");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdTipoAutenticacion).HasColumnName("id_tipoAutenticacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.MetodoAutenticar)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("metodoAutenticar");
        builder.Property(e => e.SistemaIntegrar)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("sistemaIntegrar");
        builder.Property(e => e.SistemaIntegrarCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("sistemaIntegrar_codigo");
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
            .HasDefaultValue("")
            .HasColumnName("usuario");

        builder.HasOne(d => d.IdTipoAutenticacionNavigation).WithMany(p => p.SynSistemaIntegrars)
            .HasForeignKey(d => d.IdTipoAutenticacion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__syn_siste__id_ti__38734636");
    }
}
