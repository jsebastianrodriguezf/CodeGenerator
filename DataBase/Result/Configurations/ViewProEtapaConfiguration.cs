using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewProEtapaConfiguration : IEntityTypeConfiguration<ViewProEtapa>
{
    public void Configure(EntityTypeBuilder<ViewProEtapa> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_pro_etapa");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Completado).HasColumnName("completado");
        builder.Property(e => e.Descripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
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
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFinPlaneadaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFinPlaneada_ff");
        builder.Property(e => e.FechaFinProyectadaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFinProyectada_ff");
        builder.Property(e => e.FechaFinRealFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFinReal_ff");
        builder.Property(e => e.FechaInicioPlaneadaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicioPlaneada_ff");
        builder.Property(e => e.FechaInicioProyectadaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicioProyectada_ff");
        builder.Property(e => e.FechaInicioRealFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicioReal_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Orden).HasColumnName("orden");
        builder.Property(e => e.PorcentajePresupuesto).HasColumnName("porcentajePresupuesto");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorPresupuesto)
            .HasColumnType("money")
            .HasColumnName("valorPresupuesto");
    }
}
