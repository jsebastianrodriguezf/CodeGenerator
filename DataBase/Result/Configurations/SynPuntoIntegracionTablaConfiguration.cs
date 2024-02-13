using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SynPuntoIntegracionTablaConfiguration : IEntityTypeConfiguration<SynPuntoIntegracionTabla>
{
    public void Configure(EntityTypeBuilder<SynPuntoIntegracionTabla> builder)
    {
        builder.ToTable("syn_puntoIntegracionTabla");

        builder.HasIndex(e => e.Eid, "IX_syn_puntoIntegracionTabla");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
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
        builder.Property(e => e.IdPuntoIntegracion).HasColumnName("id_puntoIntegracion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PuntoIntegracionTabla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("puntoIntegracionTabla");
        builder.Property(e => e.PuntoIntegracionTablaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("puntoIntegracionTabla_codigo");
        builder.Property(e => e.Tabla)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("tabla");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdPuntoIntegracionNavigation).WithMany(p => p.SynPuntoIntegracionTablas)
            .HasForeignKey(d => d.IdPuntoIntegracion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__syn_punto__id_pu__246C4D89");
    }
}
