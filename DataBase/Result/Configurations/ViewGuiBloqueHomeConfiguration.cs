using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGuiBloqueHomeConfiguration : IEntityTypeConfiguration<ViewGuiBloqueHome>
{
    public void Configure(EntityTypeBuilder<ViewGuiBloqueHome> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gui_bloqueHome");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Actualizacion).HasColumnName("actualizacion");
        builder.Property(e => e.BloqueHome)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("bloqueHome");
        builder.Property(e => e.BloqueHomeCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("bloqueHome_codigo");
        builder.Property(e => e.ColorModulo)
            .HasMaxLength(3)
            .IsUnicode(false)
            .HasColumnName("colorModulo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsGenerico).HasColumnName("esGenerico");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Filtro)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("filtro");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.NombreControl)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("nombreControl");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.UrlBusqueda)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("urlBusqueda");
        builder.Property(e => e.UrlNuevo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("urlNuevo");
    }
}
