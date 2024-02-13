using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquOpcionAtributoConfiguration : IEntityTypeConfiguration<EquOpcionAtributo>
{
    public void Configure(EntityTypeBuilder<EquOpcionAtributo> builder)
    {
        builder.ToTable("equ_opcionAtributo");

        builder.HasIndex(e => e.Eid, "IX_equ_opcionAtributo");

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
        builder.Property(e => e.IdAtributo).HasColumnName("id_atributo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.OpcionAtributo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("opcionAtributo");
        builder.Property(e => e.OpcionAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("opcionAtributo_codigo");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdAtributoNavigation).WithMany(p => p.EquOpcionAtributos)
            .HasForeignKey(d => d.IdAtributo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_opcionAtributo_id_atributo");
    }
}
