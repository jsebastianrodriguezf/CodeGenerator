using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocTareaConfiguration : IEntityTypeConfiguration<DocTarea>
{
    public void Configure(EntityTypeBuilder<DocTarea> builder)
    {
        builder.ToTable("doc_tarea");

        builder.HasIndex(e => e.Eid, "IX_doc_tarea");

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
        builder.Property(e => e.FechaPlaneadaFh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaPlaneada_fh");
        builder.Property(e => e.IdCargo).HasColumnName("id_cargo");
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PorcentajeAvance).HasColumnName("porcentajeAvance");
        builder.Property(e => e.Tarea)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tarea");
        builder.Property(e => e.TareaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tarea_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCargoNavigation).WithMany(p => p.DocTareas)
            .HasForeignKey(d => d.IdCargo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_tarea_id_cargo");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.DocTareas)
            .HasForeignKey(d => d.IdCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_tarea_id_catalogo");
    }
}
