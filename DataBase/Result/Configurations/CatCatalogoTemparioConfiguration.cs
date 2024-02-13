using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CatCatalogoTemparioConfiguration : IEntityTypeConfiguration<CatCatalogoTempario>
{
    public void Configure(EntityTypeBuilder<CatCatalogoTempario> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_cat_catalogo_tempario");

        builder.ToTable("cat_catalogo.tempario");

        builder.HasIndex(e => e.Eid, "IX_cat_catalogo_tempario");

        builder.Property(e => e.Id)
            .ValueGeneratedNever()
            .HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CatalogoTempario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("catalogo.tempario");
        builder.Property(e => e.DetieneEquipos)
            .HasDefaultValue(true)
            .HasColumnName("detieneEquipos");
        builder.Property(e => e.DuracionEstimada).HasColumnName("duracionEstimada");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EnTaller)
            .HasDefaultValue(true)
            .HasColumnName("enTaller");
        builder.Property(e => e.EsCiclico)
            .HasDefaultValue(true)
            .HasColumnName("esCiclico");
        builder.Property(e => e.FacturaTodo).HasColumnName("facturaTodo");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.HorasDetencion).HasColumnName("horasDetencion");
        builder.Property(e => e.IdTipoServicio).HasColumnName("id_tipoServicio");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IncluirMenores).HasColumnName("incluirMenores");
        builder.Property(e => e.ModoAjuste).HasColumnName("modoAjuste");
        builder.Property(e => e.PeriodoDias).HasColumnName("periodoDias");
        builder.Property(e => e.PeriodoHoras).HasColumnName("periodoHoras");
        builder.Property(e => e.PorcGarantia).HasColumnName("porcGarantia");
        builder.Property(e => e.PorcTropicalizacion).HasColumnName("porcTropicalizacion");
        builder.Property(e => e.Proyectar).HasColumnName("proyectar");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdTipoServicioNavigation).WithMany(p => p.CatCatalogoTemparios)
            .HasForeignKey(d => d.IdTipoServicio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cat_catalogo_tempario_id_tipoServicio");
    }
}
