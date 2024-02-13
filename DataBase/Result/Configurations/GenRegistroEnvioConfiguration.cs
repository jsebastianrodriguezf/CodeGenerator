using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenRegistroEnvioConfiguration : IEntityTypeConfiguration<GenRegistroEnvio>
{
    public void Configure(EntityTypeBuilder<GenRegistroEnvio> builder)
    {
        builder.ToTable("gen_registroEnvio");

        builder.HasIndex(e => e.Eid, "IX_gen_registroEnvio");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdEnvioCorreo).HasColumnName("id_envioCorreo");
        builder.Property(e => e.IdRegistroEnvio).HasColumnName("id_registroEnvio");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
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
            .HasDefaultValue("")
            .HasColumnName("tabla");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdEnvioCorreoNavigation).WithMany(p => p.GenRegistroEnvios)
            .HasForeignKey(d => d.IdEnvioCorreo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__gen_regis__id_en__58353EFB");

        builder.HasOne(d => d.IdRegistroEnvioNavigation).WithMany(p => p.InverseIdRegistroEnvioNavigation)
            .HasForeignKey(d => d.IdRegistroEnvio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__gen_regis__id_re__5A1D876D");
    }
}
