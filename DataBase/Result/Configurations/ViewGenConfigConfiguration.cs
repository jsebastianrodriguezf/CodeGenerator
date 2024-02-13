using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenConfigConfiguration : IEntityTypeConfiguration<ViewGenConfig>
{
    public void Configure(EntityTypeBuilder<ViewGenConfig> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_config");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Config)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("config");
        builder.Property(e => e.ConfigCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("config_codigo");
        builder.Property(e => e.Descripcion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("descripcion");
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
        builder.Property(e => e.IdObjeto).HasColumnName("idObjeto");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Modulo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("modulo");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Valor)
            .HasMaxLength(1000)
            .IsUnicode(false)
            .HasColumnName("valor");
    }
}
