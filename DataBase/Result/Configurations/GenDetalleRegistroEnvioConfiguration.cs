using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenDetalleRegistroEnvioConfiguration : IEntityTypeConfiguration<GenDetalleRegistroEnvio>
{
    public void Configure(EntityTypeBuilder<GenDetalleRegistroEnvio> builder)
    {
        builder.ToTable("gen_detalleRegistroEnvio");

        builder.HasIndex(e => e.Eid, "IX_gen_detalleRegistroEnvio");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
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
            .HasDefaultValue("")
            .HasColumnName("email");
        builder.Property(e => e.Enviado).HasColumnName("enviado");
        builder.Property(e => e.Enviar).HasColumnName("enviar");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdObjeto).HasColumnName("idObjeto");
        builder.Property(e => e.IdRegistroEnvio).HasColumnName("id_registroEnvio");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdRegistroEnvioNavigation).WithMany(p => p.GenDetalleRegistroEnvios)
            .HasForeignKey(d => d.IdRegistroEnvio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__gen_detal__id_re__5FD660C3");
    }
}
