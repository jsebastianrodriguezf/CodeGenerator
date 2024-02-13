using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SynCampoIntegracionConfiguration : IEntityTypeConfiguration<SynCampoIntegracion>
{
    public void Configure(EntityTypeBuilder<SynCampoIntegracion> builder)
    {
        builder.ToTable("syn_campoIntegracion");

        builder.HasIndex(e => e.Eid, "IX_syn_campoIntegracion");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CampoEnlace)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("campoEnlace");
        builder.Property(e => e.CampoIntegracion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("campoIntegracion");
        builder.Property(e => e.CampoIntegracionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("campoIntegracion_codigo");
        builder.Property(e => e.CampoLocal)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("campoLocal");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsLlave)
            .HasDefaultValue(false)
            .HasColumnName("esLlave");
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
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Longitud)
            .HasDefaultValue(0)
            .HasColumnName("longitud");
        builder.Property(e => e.Orden)
            .HasDefaultValue(0)
            .HasColumnName("orden");
        builder.Property(e => e.TablaAuxiliar)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("tablaAuxiliar");
        builder.Property(e => e.TipoDato)
            .HasDefaultValue(0)
            .HasColumnName("tipoDato");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorXdefecto)
            .HasMaxLength(200)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("valorXDefecto");

        builder.HasOne(d => d.IdPuntoIntegracionNavigation).WithMany(p => p.SynCampoIntegracions)
            .HasForeignKey(d => d.IdPuntoIntegracion)
            .HasConstraintName("FK__syn_campo__id_pu__562DC64F");
    }
}
