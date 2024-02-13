using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquCampanaConfiguration : IEntityTypeConfiguration<EquCampana>
{
    public void Configure(EntityTypeBuilder<EquCampana> builder)
    {
        builder.ToTable("equ_campana");

        builder.HasIndex(e => e.Eid, "IX_equ_campana");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Activo)
            .HasDefaultValue(true)
            .HasColumnName("activo");
        builder.Property(e => e.Campana)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("campana");
        builder.Property(e => e.CampanaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("campana_codigo");
        builder.Property(e => e.DetalleCampana)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("detalleCampana");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaInicioFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicio_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechafinFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechafin_ff");
        builder.Property(e => e.IdCatalogoTempario).HasColumnName("id_catalogo.tempario");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoTemparioNavigation).WithMany(p => p.EquCampanas)
            .HasForeignKey(d => d.IdCatalogoTempario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_campana_id_catalogo_tempario");

        builder.HasOne(d => d.IdTerceroNavigation).WithMany(p => p.EquCampanas)
            .HasForeignKey(d => d.IdTercero)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_campana_id_tercero");
    }
}
