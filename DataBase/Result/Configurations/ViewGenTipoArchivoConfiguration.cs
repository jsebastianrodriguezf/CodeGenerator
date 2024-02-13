using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenTipoArchivoConfiguration : IEntityTypeConfiguration<ViewGenTipoArchivo>
{
    public void Configure(EntityTypeBuilder<ViewGenTipoArchivo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_tipoArchivo");

        builder.Property(e => e.Active).HasColumnName("active");
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
        builder.Property(e => e.TipoArchivo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tipoArchivo");
        builder.Property(e => e.TipoArchivoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tipoArchivo_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
