using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquEquipoAtributoConfiguration : IEntityTypeConfiguration<EquEquipoAtributo>
{
    public void Configure(EntityTypeBuilder<EquEquipoAtributo> builder)
    {
        builder.ToTable("equ_equipoAtributo");

        builder.HasIndex(e => e.Eid, "IX_equ_equipoAtributo");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquipoAtributo)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("equipoAtributo");
        builder.Property(e => e.EquipoAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equipoAtributo_codigo");
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
        builder.Property(e => e.IdAtributo).HasColumnName("id_atributo");
        builder.Property(e => e.IdDocumentoOt).HasColumnName("id_documento.ot");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdEvento).HasColumnName("id_evento");
        builder.Property(e => e.IdOpcionAtributo).HasColumnName("id_opcionAtributo");
        builder.Property(e => e.IdPruebaCheckList).HasColumnName("id_pruebaCheckList");
        builder.Property(e => e.IdReporteTecnico).HasColumnName("id_reporteTecnico");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdAtributoNavigation).WithMany(p => p.EquEquipoAtributos)
            .HasForeignKey(d => d.IdAtributo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_equipoAtributo_id_atributo");

        builder.HasOne(d => d.IdDocumentoOtNavigation).WithMany(p => p.EquEquipoAtributos)
            .HasForeignKey(d => d.IdDocumentoOt)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_equipoAtributo_id_documento_ot");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.EquEquipoAtributos)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_equipoAtributo_id_equipo");

        builder.HasOne(d => d.IdEventoNavigation).WithMany(p => p.EquEquipoAtributos)
            .HasForeignKey(d => d.IdEvento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK__equ_equip__id_ev__32263B5A");

        builder.HasOne(d => d.IdOpcionAtributoNavigation).WithMany(p => p.EquEquipoAtributos)
            .HasForeignKey(d => d.IdOpcionAtributo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_equipoAtributo_id_opcionAtributo");

        builder.HasOne(d => d.IdReporteTecnicoNavigation).WithMany(p => p.EquEquipoAtributos)
            .HasForeignKey(d => d.IdReporteTecnico)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_equipoAtributo_id_reporteTecnico");
    }
}
