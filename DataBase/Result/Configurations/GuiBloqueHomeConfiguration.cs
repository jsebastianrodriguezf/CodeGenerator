using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GuiBloqueHomeConfiguration : IEntityTypeConfiguration<GuiBloqueHome>
{
    public void Configure(EntityTypeBuilder<GuiBloqueHome> builder)
    {
        builder.ToTable("gui_bloqueHome");

        builder.HasIndex(e => e.Eid, "IX_gui_bloqueHome");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Actualizacion)
            .HasDefaultValue(false)
            .HasColumnName("actualizacion");
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
            .HasDefaultValue("")
            .HasColumnName("colorModulo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsGenerico)
            .HasDefaultValue(true)
            .HasColumnName("esGenerico");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Filtro)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("filtro");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.NombreControl)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("nombreControl");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.UrlBusqueda)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("urlBusqueda");
        builder.Property(e => e.UrlNuevo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("urlNuevo");
    }
}
