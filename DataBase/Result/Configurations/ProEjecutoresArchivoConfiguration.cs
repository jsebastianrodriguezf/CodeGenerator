using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ProEjecutoresArchivoConfiguration : IEntityTypeConfiguration<ProEjecutoresArchivo>
{
    public void Configure(EntityTypeBuilder<ProEjecutoresArchivo> builder)
    {
        builder.ToTable("pro_ejecutores_archivo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Aprobado)
            .HasDefaultValue(false)
            .HasColumnName("aprobado");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EjecutoresArchivo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ejecutores_archivo");
        builder.Property(e => e.FechaAprobacion)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("datetime")
            .HasColumnName("fecha_aprobacion");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaRevision)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("datetime")
            .HasColumnName("fecha_revision");
        builder.Property(e => e.IdArchivo).HasColumnName("id_archivo");
        builder.Property(e => e.IdEjecutores).HasColumnName("id_ejecutores");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Revisado)
            .HasDefaultValue(false)
            .HasColumnName("revisado");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdArchivoNavigation).WithMany(p => p.ProEjecutoresArchivos)
            .HasForeignKey(d => d.IdArchivo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_pro_ejecutor_archivo_id_archivo");

        builder.HasOne(d => d.IdEjecutoresNavigation).WithMany(p => p.ProEjecutoresArchivos)
            .HasForeignKey(d => d.IdEjecutores)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_pro_ejecutor_archivo_id_ejecutores");
    }
}
