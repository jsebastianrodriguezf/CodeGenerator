using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class OrtMotivoCancelacionConfiguration : IEntityTypeConfiguration<OrtMotivoCancelacion>
{
    public void Configure(EntityTypeBuilder<OrtMotivoCancelacion> builder)
    {
        builder.ToTable("ort_motivoCancelacion");

        builder.HasIndex(e => e.Eid, "IX_ort_motivoCancelacion");

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
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.MotivoCancelacion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("motivoCancelacion");
        builder.Property(e => e.MotivoCancelacionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("motivoCancelacion_codigo");
        builder.Property(e => e.ResponsableServicio).HasColumnName("responsableServicio");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
