using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SynPuntoIntegracionEstadoTipoDocumentoConfiguration : IEntityTypeConfiguration<SynPuntoIntegracionEstadoTipoDocumento>
{
    public void Configure(EntityTypeBuilder<SynPuntoIntegracionEstadoTipoDocumento> builder)
    {
        builder.ToTable("syn_puntoIntegracion_estadoTipoDocumento");

        builder.HasIndex(e => e.Eid, "IX_syn_puntoIntegracion_estadoTipoDocumento");

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
        builder.Property(e => e.IdEstadoTipoDocumento)
            .HasDefaultValue(0)
            .HasColumnName("id_estadoTipoDocumento");
        builder.Property(e => e.IdPuntoIntegracion)
            .HasDefaultValue(0)
            .HasColumnName("id_puntoIntegracion");
        builder.Property(e => e.IdRolEstado).HasColumnName("idRolEstado");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PuntoIntegracionEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("puntoIntegracion_estadoTipoDocumento");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdEstadoTipoDocumentoNavigation).WithMany(p => p.SynPuntoIntegracionEstadoTipoDocumentos)
            .HasForeignKey(d => d.IdEstadoTipoDocumento)
            .HasConstraintName("FK__syn_punto__id_es__58160EC1");

        builder.HasOne(d => d.IdPuntoIntegracionNavigation).WithMany(p => p.SynPuntoIntegracionEstadoTipoDocumentos)
            .HasForeignKey(d => d.IdPuntoIntegracion)
            .HasConstraintName("FK__syn_punto__id_pu__5074ECF9");
    }
}
