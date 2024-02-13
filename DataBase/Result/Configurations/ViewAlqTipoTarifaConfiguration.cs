using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewAlqTipoTarifaConfiguration : IEntityTypeConfiguration<ViewAlqTipoTarifa>
{
    public void Configure(EntityTypeBuilder<ViewAlqTipoTarifa> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_alq_tipoTarifa");

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
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.TipoTarifa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tipoTarifa");
        builder.Property(e => e.TipoTarifaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tipoTarifa_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Valor)
            .HasColumnType("decimal(10, 1)")
            .HasColumnName("valor");
    }
}
