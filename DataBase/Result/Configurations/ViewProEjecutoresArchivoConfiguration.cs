using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewProEjecutoresArchivoConfiguration : IEntityTypeConfiguration<ViewProEjecutoresArchivo>
{
    public void Configure(EntityTypeBuilder<ViewProEjecutoresArchivo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_pro_ejecutores_archivo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Aprobado).HasColumnName("aprobado");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EjecutoresArchivo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ejecutores_archivo");
        builder.Property(e => e.FechaAprobacion)
            .HasColumnType("datetime")
            .HasColumnName("fecha_aprobacion");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaRevision)
            .HasColumnType("datetime")
            .HasColumnName("fecha_revision");
        builder.Property(e => e.GenArchivoArchivo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_archivo_archivo");
        builder.Property(e => e.GenArchivoArchivoBinario)
            .HasColumnType("image")
            .HasColumnName("gen_archivo_archivoBinario");
        builder.Property(e => e.GenArchivoArchivoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_archivo_archivo_codigo");
        builder.Property(e => e.GenArchivoDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("gen_archivo_descripcion");
        builder.Property(e => e.GenArchivoEsPrincipal).HasColumnName("gen_archivo_esPrincipal");
        builder.Property(e => e.GenArchivoIdObjeto).HasColumnName("gen_archivo_idObjeto");
        builder.Property(e => e.GenArchivoLink)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("gen_archivo_link");
        builder.Property(e => e.GenArchivoTabla)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_archivo_tabla");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdArchivo).HasColumnName("id_archivo");
        builder.Property(e => e.IdEjecutores).HasColumnName("id_ejecutores");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.ProEjecutoresCosto).HasColumnName("pro_ejecutores_costo");
        builder.Property(e => e.ProEjecutoresEjecutores)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pro_ejecutores_ejecutores");
        builder.Property(e => e.ProEjecutoresEjecutoresCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pro_ejecutores_ejecutores_codigo");
        builder.Property(e => e.ProEjecutoresIdHorarioEjecutores).HasColumnName("pro_ejecutores_id_horarioEjecutores");
        builder.Property(e => e.ProEjecutoresIdUsuario).HasColumnName("pro_ejecutores_id_usuario");
        builder.Property(e => e.ProEjecutoresUnidadTiempo)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasColumnName("pro_ejecutores_unidadTiempo");
        builder.Property(e => e.Revisado).HasColumnName("revisado");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
