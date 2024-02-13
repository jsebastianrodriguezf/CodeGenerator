using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocCosteoConfiguration : IEntityTypeConfiguration<ViewDocCosteo>
{
    public void Configure(EntityTypeBuilder<ViewDocCosteo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_costeo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Costeo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("costeo");
        builder.Property(e => e.CosteoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("costeo_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
