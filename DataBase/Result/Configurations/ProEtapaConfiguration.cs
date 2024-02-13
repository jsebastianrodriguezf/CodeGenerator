using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ProEtapaConfiguration : IEntityTypeConfiguration<ProEtapa>
{
    public void Configure(EntityTypeBuilder<ProEtapa> builder)
    {
        builder.ToTable("pro_etapa");

        builder.HasIndex(e => e.Eid, "IX_pro_etapa");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Completado)
            .HasDefaultValue(0)
            .HasColumnName("completado");
        builder.Property(e => e.Descripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasDefaultValueSql("((0))")
            .HasColumnName("descripcion");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Etapa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("etapa");
        builder.Property(e => e.EtapaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("etapa_codigo");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFinPlaneada)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("datetime")
            .HasColumnName("fechaFinPlaneada");
        builder.Property(e => e.FechaFinPlaneadaFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFinPlaneada_ff");
        builder.Property(e => e.FechaFinProyectada)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("datetime")
            .HasColumnName("fechaFinProyectada");
        builder.Property(e => e.FechaFinProyectadaFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFinProyectada_ff");
        builder.Property(e => e.FechaFinReal)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("datetime")
            .HasColumnName("fechaFinReal");
        builder.Property(e => e.FechaFinRealFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFinReal_ff");
        builder.Property(e => e.FechaInicioPlaneada)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("datetime")
            .HasColumnName("fechaInicioPlaneada");
        builder.Property(e => e.FechaInicioPlaneadaFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicioPlaneada_ff");
        builder.Property(e => e.FechaInicioProyectada)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("datetime")
            .HasColumnName("fechaInicioProyectada");
        builder.Property(e => e.FechaInicioProyectadaFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicioProyectada_ff");
        builder.Property(e => e.FechaInicioReal)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("datetime")
            .HasColumnName("fechaInicioReal");
        builder.Property(e => e.FechaInicioRealFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicioReal_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Orden)
            .HasDefaultValue(0)
            .HasColumnName("orden");
        builder.Property(e => e.PorcentajePresupuesto)
            .HasDefaultValue(0.0)
            .HasColumnName("porcentajePresupuesto");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorPresupuesto)
            .HasDefaultValue(0.0m)
            .HasColumnType("money")
            .HasColumnName("valorPresupuesto");
    }
}
