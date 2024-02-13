using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class EquCicloHorometroConfiguration : IEntityTypeConfiguration<EquCicloHorometro>
{
    public void Configure(EntityTypeBuilder<EquCicloHorometro> builder)
    {
        builder.ToTable("equ_cicloHorometro");

        builder.HasIndex(e => e.Eid, "IX_equ_cicloHorometro");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.AfectarProyeccion).HasColumnName("afectarProyeccion");
        builder.Property(e => e.CicloHorometro)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cicloHorometro");
        builder.Property(e => e.CicloHorometroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cicloHorometro_codigo");
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
        builder.Property(e => e.HorometroFinal).HasColumnName("horometroFinal");
        builder.Property(e => e.HorometroInicial).HasColumnName("horometroInicial");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.ReiniciarHorometro).HasColumnName("reiniciarHorometro");
        builder.Property(e => e.ReparacionMayor).HasColumnName("reparacionMayor");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdEquipoNavigation).WithMany(p => p.EquCicloHorometros)
            .HasForeignKey(d => d.IdEquipo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_equ_cicloHorometro_id_equipo");
    }
}
