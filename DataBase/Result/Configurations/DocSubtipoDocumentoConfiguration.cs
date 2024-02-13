using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocSubtipoDocumentoConfiguration : IEntityTypeConfiguration<DocSubtipoDocumento>
{
    public void Configure(EntityTypeBuilder<DocSubtipoDocumento> builder)
    {
        builder.ToTable("doc_subtipoDocumento");

        builder.HasIndex(e => e.Eid, "IX_doc_subtipoDocumento");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.ArchivosAdjuntosApp)
            .HasDefaultValue(1)
            .HasColumnName("archivosAdjuntosApp");
        builder.Property(e => e.BloquearDespacho).HasColumnName("bloquearDespacho");
        builder.Property(e => e.CantidadAuxiliar)
            .HasDefaultValue(true)
            .HasColumnName("cantidadAuxiliar");
        builder.Property(e => e.CargarSolicitante).HasColumnName("cargarSolicitante");
        builder.Property(e => e.CerrarSol)
            .HasDefaultValue(true)
            .HasColumnName("cerrarSol");
        builder.Property(e => e.Consecutivo)
            .HasDefaultValue(1)
            .HasColumnName("consecutivo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EjecutaDevolucion)
            .HasDefaultValue(true)
            .HasColumnName("ejecutaDevolucion");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdTipoDocumento).HasColumnName("id_tipoDocumento");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.MostrarPendienteDocumento).HasColumnName("mostrarPendienteDocumento");
        builder.Property(e => e.MostrarValoresEjecutados)
            .HasDefaultValue(true)
            .HasColumnName("mostrarValoresEjecutados");
        builder.Property(e => e.Prefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("prefijo");
        builder.Property(e => e.ProgramarPlaneadas).HasColumnName("programarPlaneadas");
        builder.Property(e => e.SubtipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("subtipoDocumento");
        builder.Property(e => e.SubtipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("subtipoDocumento_codigo");
        builder.Property(e => e.TipoCobro).HasColumnName("tipoCobro");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValUrgente).HasColumnName("valUrgente");
        builder.Property(e => e.VerCentroCosto).HasColumnName("verCentroCosto");
        builder.Property(e => e.VerIncoterm).HasColumnName("verIncoterm");

        builder.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.DocSubtipoDocumentos)
            .HasForeignKey(d => d.IdTipoDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_subtipoDocumento_id_tipoDocumento");
    }
}
