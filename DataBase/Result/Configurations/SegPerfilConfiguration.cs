using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SegPerfilConfiguration : IEntityTypeConfiguration<SegPerfil>
{
    public void Configure(EntityTypeBuilder<SegPerfil> builder)
    {
        builder.ToTable("seg_perfil");

        builder.HasIndex(e => e.Eid, "IX_seg_perfil");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Descripcion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("descripcion");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.MostrarBotones).HasColumnName("mostrarBotones");
        builder.Property(e => e.ParaCliente)
            .HasDefaultValue(false)
            .HasColumnName("paraCliente");
        builder.Property(e => e.ParaProveedor)
            .HasDefaultValue(false)
            .HasColumnName("paraProveedor");
        builder.Property(e => e.Perfil)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("perfil");
        builder.Property(e => e.PerfilCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("perfil_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
