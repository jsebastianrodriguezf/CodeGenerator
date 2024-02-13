using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewSynPuntoIntegracionTablaConfiguration : IEntityTypeConfiguration<ViewSynPuntoIntegracionTabla>
{
    public void Configure(EntityTypeBuilder<ViewSynPuntoIntegracionTabla> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_syn_puntoIntegracionTabla");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdPuntoIntegracion).HasColumnName("id_puntoIntegracion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PuntoIntegracionTabla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("puntoIntegracionTabla");
        builder.Property(e => e.PuntoIntegracionTablaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("puntoIntegracionTabla_codigo");
        builder.Property(e => e.SynPuntoIntegracionCondicion)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_condicion");
        builder.Property(e => e.SynPuntoIntegracionIdPuntoIntegracion).HasColumnName("syn_puntoIntegracion_id_puntoIntegracion");
        builder.Property(e => e.SynPuntoIntegracionIdSistemaIntegrar).HasColumnName("syn_puntoIntegracion_id_sistemaIntegrar");
        builder.Property(e => e.SynPuntoIntegracionMetodo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_metodo");
        builder.Property(e => e.SynPuntoIntegracionPuntoIntegracion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_puntoIntegracion");
        builder.Property(e => e.SynPuntoIntegracionPuntoIntegracionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_puntoIntegracion_codigo");
        builder.Property(e => e.SynPuntoIntegracionTablaLocal)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_tablaLocal");
        builder.Property(e => e.SynPuntoIntegracionUrlConsumir)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("syn_puntoIntegracion_urlConsumir");
        builder.Property(e => e.Tabla)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("tabla");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
