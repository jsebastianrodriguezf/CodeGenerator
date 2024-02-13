using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenFirmaConfiguration : IEntityTypeConfiguration<ViewGenFirma>
{
    public void Configure(EntityTypeBuilder<ViewGenFirma> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_firma");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Archivobinario)
            .HasColumnType("image")
            .HasColumnName("archivobinario");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_fh");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Firma)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("firma");
        builder.Property(e => e.FirmaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("firma_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Idobjeto).HasColumnName("idobjeto");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Tabla)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tabla");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
