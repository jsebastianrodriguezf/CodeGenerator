using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCatVersionEquipoDetalleTemparioConfiguration : IEntityTypeConfiguration<ViewCatVersionEquipoDetalleTempario>
{
    public void Configure(EntityTypeBuilder<ViewCatVersionEquipoDetalleTempario> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cat_versionEquipo_detalleTempario");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatDetalleTemparioCantidadEstandar).HasColumnName("cat_detalleTempario_cantidadEstandar");
        builder.Property(e => e.CatDetalleTemparioCantidadTropicalizada).HasColumnName("cat_detalleTempario_cantidadTropicalizada");
        builder.Property(e => e.CatDetalleTemparioDetalleTempario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_detalleTempario_detalleTempario");
        builder.Property(e => e.CatDetalleTemparioDetalleTemparioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_detalleTempario_detalleTempario_codigo");
        builder.Property(e => e.CatDetalleTemparioIdCatalogo).HasColumnName("cat_detalleTempario_id_catalogo");
        builder.Property(e => e.CatDetalleTemparioIdCatalogoTempario).HasColumnName("cat_detalleTempario_id_catalogo.tempario");
        builder.Property(e => e.CatDetalleTemparioIdDetalleTemparioPadre).HasColumnName("cat_detalleTempario_id_detalleTempario_padre");
        builder.Property(e => e.CatDetalleTemparioIdPruebaCheckList).HasColumnName("cat_detalleTempario_id_pruebaCheckList");
        builder.Property(e => e.CatDetalleTemparioIdSistema).HasColumnName("cat_detalleTempario_id_sistema");
        builder.Property(e => e.CatDetalleTemparioOrden).HasColumnName("cat_detalleTempario_orden");
        builder.Property(e => e.CatVersionEquipoIdCatalogoEquipo).HasColumnName("cat_versionEquipo_id_catalogo.equipo");
        builder.Property(e => e.CatVersionEquipoVersionEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_versionEquipo_versionEquipo");
        builder.Property(e => e.CatVersionEquipoVersionEquipoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_versionEquipo_versionEquipo_codigo");
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
        builder.Property(e => e.IdDetalleTempario).HasColumnName("id_detalleTempario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdVersionEquipo).HasColumnName("id_versionEquipo");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.VersionEquipoDetalleTempario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("versionEquipo_detalleTempario");
    }
}
