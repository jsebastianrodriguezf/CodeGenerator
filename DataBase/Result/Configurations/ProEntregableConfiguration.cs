using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ProEntregableConfiguration : IEntityTypeConfiguration<ProEntregable>
{
    public void Configure(EntityTypeBuilder<ProEntregable> builder)
    {
        builder.ToTable("pro_entregable");

        builder.HasIndex(e => e.Eid, "IX_pro_entregable");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Entregable)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("entregable");
        builder.Property(e => e.EntregableCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("entregable_codigo");
        builder.Property(e => e.EsExterno)
            .HasDefaultValue(true)
            .HasColumnName("esExterno");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaPlaneada)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaPlaneada");
        builder.Property(e => e.FechaProyectada)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaProyectada");
        builder.Property(e => e.FechaReal)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaReal");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Nombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValueSql("((0))")
            .HasColumnName("nombre");
        builder.Property(e => e.PorcentajePlaneado).HasColumnName("porcentajePlaneado");
        builder.Property(e => e.PorcentajeReal).HasColumnName("porcentajeReal");
        builder.Property(e => e.Producto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValueSql("((0))")
            .HasColumnName("producto");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorPlaneado).HasColumnName("valorPlaneado");
        builder.Property(e => e.ValorReal).HasColumnName("valorReal");
    }
}
