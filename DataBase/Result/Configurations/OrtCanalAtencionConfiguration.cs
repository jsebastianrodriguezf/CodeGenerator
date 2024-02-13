using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class OrtCanalAtencionConfiguration : IEntityTypeConfiguration<OrtCanalAtencion>
{
    public void Configure(EntityTypeBuilder<OrtCanalAtencion> builder)
    {
        builder.ToTable("ort_canalAtencion");

        builder.HasIndex(e => e.Eid, "IX_ort_canalAtencion");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CanalAtencion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("canalAtencion");
        builder.Property(e => e.CanalAtencionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("canalAtencion_codigo");
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
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
