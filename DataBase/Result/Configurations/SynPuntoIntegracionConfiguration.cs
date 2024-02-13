using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SynPuntoIntegracionConfiguration : IEntityTypeConfiguration<SynPuntoIntegracion>
{
    public void Configure(EntityTypeBuilder<SynPuntoIntegracion> builder)
    {
        builder.ToTable("syn_puntoIntegracion");

        builder.HasIndex(e => e.Eid, "IX_syn_puntoIntegracion");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CantidadReintentos).HasColumnName("cantidadReintentos");
        builder.Property(e => e.CodigosReintentos)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasColumnName("codigosReintentos");
        builder.Property(e => e.Condicion)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("condicion");
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
        builder.Property(e => e.IdPuntoIntegracion)
            .HasDefaultValue(0)
            .HasColumnName("id_puntoIntegracion");
        builder.Property(e => e.IdSistemaIntegrar)
            .HasDefaultValue(0)
            .HasColumnName("id_sistemaIntegrar");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IntervaloReintentos).HasColumnName("intervaloReintentos");
        builder.Property(e => e.Metodo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("metodo");
        builder.Property(e => e.PuntoIntegracion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("puntoIntegracion");
        builder.Property(e => e.PuntoIntegracionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("puntoIntegracion_codigo");
        builder.Property(e => e.TablaLocal)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("tablaLocal");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.UrlConsumir)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("urlConsumir");

        builder.HasOne(d => d.IdPuntoIntegracionNavigation).WithMany(p => p.InverseIdPuntoIntegracionNavigation)
            .HasForeignKey(d => d.IdPuntoIntegracion)
            .HasConstraintName("FK__syn_punto__id_pu__46EB82BF");

        builder.HasOne(d => d.IdSistemaIntegrarNavigation).WithMany(p => p.SynPuntoIntegracions)
            .HasForeignKey(d => d.IdSistemaIntegrar)
            .HasConstraintName("FK__syn_punto__id_si__54457DDD");
    }
}
