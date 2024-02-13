using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DisMotivoEventoConfiguration : IEntityTypeConfiguration<DisMotivoEvento>
{
    public void Configure(EntityTypeBuilder<DisMotivoEvento> builder)
    {
        builder.ToTable("dis_motivoEvento");

        builder.HasIndex(e => e.Eid, "IX_dis_motivoEvento");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsFalla).HasColumnName("esFalla");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.MotivoEvento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("motivoEvento");
        builder.Property(e => e.MotivoEventoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("motivoEvento_codigo");
        builder.Property(e => e.ResponsableServicio).HasColumnName("responsableServicio");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
