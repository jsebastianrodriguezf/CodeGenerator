using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquOpcionAtributoDependienteConfiguration : IEntityTypeConfiguration<EquOpcionAtributoDependiente>
{
    public void Configure(EntityTypeBuilder<EquOpcionAtributoDependiente> builder)
    {
        builder.ToTable("equ_opcionAtributoDependiente");

        builder.HasIndex(e => e.Eid, "IX_equ_opcionAtributoDependiente");

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
        builder.Property(e => e.IdOpcionAtributoHijo)
            .HasDefaultValue(0)
            .HasColumnName("id_opcionAtributo_hijo");
        builder.Property(e => e.IdOpcionAtributoPadre)
            .HasDefaultValue(0)
            .HasColumnName("id_opcionAtributo_padre");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.OpcionAtributoDependiente)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("opcionAtributoDependiente");
        builder.Property(e => e.OpcionAtributoDependienteCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("opcionAtributoDependiente_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdOpcionAtributoHijoNavigation).WithMany(p => p.EquOpcionAtributoDependientes)
            .HasForeignKey(d => d.IdOpcionAtributoHijo)
            .HasConstraintName("FK__equ_opcio__id_op__49A7F3D9");
    }
}
