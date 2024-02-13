using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquOverhallConfiguration : IEntityTypeConfiguration<EquOverhall>
{
    public void Configure(EntityTypeBuilder<EquOverhall> builder)
    {
        builder.ToTable("equ_overhall");

        builder.HasIndex(e => e.Eid, "IX_equ_overhall");

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
        builder.Property(e => e.FechaFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Horometro).HasColumnName("horometro");
        builder.Property(e => e.IdDocumentoOt).HasColumnName("id_documento.ot");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Overhall)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("overhall");
        builder.Property(e => e.OverhallCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("overhall_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdDocumentoOtNavigation).WithMany(p => p.EquOverhalls)
            .HasForeignKey(d => d.IdDocumentoOt)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_overhall_id_documento_ot");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.EquOverhalls)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_overhall_id_equipo");
    }
}
