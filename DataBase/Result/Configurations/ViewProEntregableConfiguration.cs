using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewProEntregableConfiguration : IEntityTypeConfiguration<ViewProEntregable>
{
    public void Configure(EntityTypeBuilder<ViewProEntregable> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_pro_entregable");

        builder.Property(e => e.Active).HasColumnName("active");
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
        builder.Property(e => e.EsExterno).HasColumnName("esExterno");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaPlaneada)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaPlaneada");
        builder.Property(e => e.FechaProyectada)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaProyectada");
        builder.Property(e => e.FechaReal)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaReal");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Nombre)
            .HasMaxLength(100)
            .IsUnicode(false);
        builder.Property(e => e.PorcentajePlaneado).HasColumnName("porcentajePlaneado");
        builder.Property(e => e.PorcentajeReal).HasColumnName("porcentajeReal");
        builder.Property(e => e.Producto)
            .HasMaxLength(100)
            .IsUnicode(false);
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorPlaneado).HasColumnName("valorPlaneado");
        builder.Property(e => e.ValorReal).HasColumnName("valorReal");
    }
}
