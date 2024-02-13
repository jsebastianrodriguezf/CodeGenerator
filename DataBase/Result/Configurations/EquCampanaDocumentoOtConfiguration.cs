using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquCampanaDocumentoOtConfiguration : IEntityTypeConfiguration<EquCampanaDocumentoOt>
{
    public void Configure(EntityTypeBuilder<EquCampanaDocumentoOt> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_equ_campana_documento_OT");

        builder.ToTable("equ_campana_documento.OT");

        builder.HasIndex(e => e.Eid, "IX_equ_campana_documento_OT");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CampanaDocumentoOt)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("campana_documento.OT");
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
        builder.Property(e => e.IdCampana).HasColumnName("id_campana");
        builder.Property(e => e.IdDocumentoOt).HasColumnName("id_documento.ot");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCampanaNavigation).WithMany(p => p.EquCampanaDocumentoOts)
            .HasForeignKey(d => d.IdCampana)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_campana_documento_OT_id_campana");

        builder.HasOne(d => d.IdDocumentoOtNavigation).WithMany(p => p.EquCampanaDocumentoOts)
            .HasForeignKey(d => d.IdDocumentoOt)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_campana_documento_OT_id_documento_ot");
    }
}
