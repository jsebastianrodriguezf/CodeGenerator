using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenConfiguracionServicioConfiguration : IEntityTypeConfiguration<GenConfiguracionServicio>
{
    public void Configure(EntityTypeBuilder<GenConfiguracionServicio> builder)
    {
        builder.ToTable("gen_configuracionServicio");

        builder.HasIndex(e => e.Eid, "IX_gen_configuracionServicio");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.ConfiguracionServicio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("configuracionServicio");
        builder.Property(e => e.ConfiguracionServicioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("configuracionServicio_codigo");
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
        builder.Property(e => e.IdCatalogo)
            .HasDefaultValue(0)
            .HasColumnName("id_catalogo");
        builder.Property(e => e.IdTercero)
            .HasDefaultValue(0)
            .HasColumnName("id_tercero");
        builder.Property(e => e.IdTipoServicio)
            .HasDefaultValue(0)
            .HasColumnName("id_tipoServicio");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.GenConfiguracionServicios)
            .HasForeignKey(d => d.IdCatalogo)
            .HasConstraintName("FK__gen_confi__id_ca__7A16210A");

        builder.HasOne(d => d.IdTerceroNavigation).WithMany(p => p.GenConfiguracionServicios)
            .HasForeignKey(d => d.IdTercero)
            .HasConstraintName("FK__gen_confi__id_te__76459026");

        builder.HasOne(d => d.IdTipoServicioNavigation).WithMany(p => p.GenConfiguracionServicios)
            .HasForeignKey(d => d.IdTipoServicio)
            .HasConstraintName("FK__gen_confi__id_ti__782DD898");
    }
}
