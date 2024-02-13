using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGuiDetalleBloqueHomeConfiguration : IEntityTypeConfiguration<ViewGuiDetalleBloqueHome>
{
    public void Configure(EntityTypeBuilder<ViewGuiDetalleBloqueHome> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gui_detalleBloqueHome");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DetalleBloqueHome)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("detalleBloqueHome");
        builder.Property(e => e.DetalleBloqueHomeCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("detalleBloqueHome_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EstrategiaFecha).HasColumnName("estrategiaFecha");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GuiBloqueHomeBloqueHome)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gui_bloqueHome_bloqueHome");
        builder.Property(e => e.GuiBloqueHomeBloqueHomeCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_bloqueHome_bloqueHome_codigo");
        builder.Property(e => e.GuiBloqueHomeColorModulo)
            .HasMaxLength(3)
            .IsUnicode(false)
            .HasColumnName("gui_bloqueHome_colorModulo");
        builder.Property(e => e.GuiBloqueHomeEsGenerico).HasColumnName("gui_bloqueHome_esGenerico");
        builder.Property(e => e.GuiBloqueHomeFiltro)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("gui_bloqueHome_filtro");
        builder.Property(e => e.GuiBloqueHomeNombreControl)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_bloqueHome_nombreControl");
        builder.Property(e => e.GuiBloqueHomeOrden).HasColumnName("gui_bloqueHome_orden");
        builder.Property(e => e.GuiBloqueHomeUrlBusqueda)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_bloqueHome_urlBusqueda");
        builder.Property(e => e.GuiBloqueHomeUrlNuevo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gui_bloqueHome_urlNuevo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdBloqueHome).HasColumnName("id_bloqueHome");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.ItemsTab).HasColumnName("itemsTab");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.OrdenResultados).HasColumnName("ordenResultados");
        builder.Property(e => e.PosicionTab).HasColumnName("posicionTab");
        builder.Property(e => e.TipoBloqueHome).HasColumnName("tipoBloqueHome");
        builder.Property(e => e.TipoCampo).HasColumnName("tipoCampo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
