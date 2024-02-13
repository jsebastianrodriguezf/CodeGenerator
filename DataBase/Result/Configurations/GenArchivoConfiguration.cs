using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenArchivoConfiguration : IEntityTypeConfiguration<GenArchivo>
{
    public void Configure(EntityTypeBuilder<GenArchivo> builder)
    {
        builder.ToTable("gen_archivo");

        builder.HasIndex(e => e.Eid, "IX_gen_archivo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Archivo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("archivo");
        builder.Property(e => e.ArchivoBinario)
            .HasColumnType("image")
            .HasColumnName("archivoBinario");
        builder.Property(e => e.ArchivoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("archivo_codigo");
        builder.Property(e => e.Descripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("descripcion");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsPrincipal)
            .HasDefaultValue(false)
            .HasColumnName("esPrincipal");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdObjeto).HasColumnName("idObjeto");
        builder.Property(e => e.IdTipoArchivo).HasColumnName("id_tipoArchivo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Link)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("link");
        builder.Property(e => e.Tabla)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("tabla");
        builder.Property(e => e.Tamano).HasColumnName("tamano");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
