using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ProHorarioProyectoConfiguration : IEntityTypeConfiguration<ProHorarioProyecto>
{
    public void Configure(EntityTypeBuilder<ProHorarioProyecto> builder)
    {
        builder.ToTable("pro_horarioProyecto");

        builder.HasIndex(e => e.Eid, "IX_pro_horarioProyecto");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Domingo)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("domingo");
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
        builder.Property(e => e.Festivos)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("festivos");
        builder.Property(e => e.HorarioProyecto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("horarioProyecto");
        builder.Property(e => e.HorarioProyectoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("horarioProyecto_codigo");
        builder.Property(e => e.IdDocumentoProyecto).HasColumnName("id_documento.proyecto");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Jueves)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("jueves");
        builder.Property(e => e.Lunes)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("lunes");
        builder.Property(e => e.Martes)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("martes");
        builder.Property(e => e.Miercoles)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("miercoles");
        builder.Property(e => e.Sabado)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("sabado");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Viernes)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("viernes");

        builder.HasOne(d => d.IdDocumentoProyectoNavigation).WithMany(p => p.ProHorarioProyectos)
            .HasForeignKey(d => d.IdDocumentoProyecto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_pro_horarioProyecto_id_proyecto");
    }
}
