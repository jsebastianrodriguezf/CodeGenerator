using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocItemDocumentoConfiguration : IEntityTypeConfiguration<DocItemDocumento>
{
    public void Configure(EntityTypeBuilder<DocItemDocumento> builder)
    {
        builder.ToTable("doc_itemDocumento");

        builder.HasIndex(e => e.Eid, "IX_doc_itemDocumento");

        builder.HasIndex(e => e.IdDocumento, "IX_id_documento");

        builder.HasIndex(e => e.IdItemDocumento, "IX_id_itemDocumento");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.AfectoInventario).HasColumnName("afectoInventario");
        builder.Property(e => e.CantAuxiliar)
            .HasDefaultValue(1.0)
            .HasColumnName("cantAuxiliar");
        builder.Property(e => e.CantidadEjecutado).HasColumnName("cantidadEjecutado");
        builder.Property(e => e.CantidadPlaneado).HasColumnName("cantidadPlaneado");
        builder.Property(e => e.Costear)
            .HasDefaultValue(true)
            .HasColumnName("costear");
        builder.Property(e => e.CostoEjecutado).HasColumnName("costoEjecutado");
        builder.Property(e => e.CostoPlaneado).HasColumnName("costoPlaneado");
        builder.Property(e => e.Detalle)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("detalle");
        builder.Property(e => e.DtoEjecutado)
            .HasColumnType("money")
            .HasColumnName("dtoEjecutado");
        builder.Property(e => e.DtoPlaneado)
            .HasColumnType("money")
            .HasColumnName("dtoPlaneado");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsUrgente)
            .HasDefaultValue(true)
            .HasColumnName("esUrgente");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.HorasFestivas).HasColumnName("horasFestivas");
        builder.Property(e => e.HorasGarantia).HasColumnName("horasGarantia");
        builder.Property(e => e.HorasNocturnas).HasColumnName("horasNocturnas");
        builder.Property(e => e.HorasOrdinales).HasColumnName("horasOrdinales");
        builder.Property(e => e.IdBodega).HasColumnName("id_bodega");
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdCentroCosto).HasColumnName("id_centroCosto");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdIncoterm).HasColumnName("id_incoterm");
        builder.Property(e => e.IdItemDocumento).HasColumnName("id_itemDocumento");
        builder.Property(e => e.IdItemDocumentoSuperior).HasColumnName("id_itemDocumento_superior");
        builder.Property(e => e.IdListaprecio).HasColumnName("id_listaprecio");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.ItemDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("itemDocumento");
        builder.Property(e => e.ItemDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("itemDocumento_codigo");
        builder.Property(e => e.IvaEjecutado)
            .HasColumnType("money")
            .HasColumnName("ivaEjecutado");
        builder.Property(e => e.IvaPlaneado)
            .HasColumnType("money")
            .HasColumnName("ivaPlaneado");
        builder.Property(e => e.MargenPlaneado).HasColumnName("margenPlaneado");
        builder.Property(e => e.Porcdescuento)
            .HasDefaultValue(0.0)
            .HasColumnName("porcdescuento");
        builder.Property(e => e.Porcdto).HasColumnName("porcdto");
        builder.Property(e => e.PorcentajeCliente)
            .HasDefaultValue(100.0)
            .HasColumnName("porcentajeCliente");
        builder.Property(e => e.PorcentajeDistribuidor).HasColumnName("porcentajeDistribuidor");
        builder.Property(e => e.PorcentajeFabricante).HasColumnName("porcentajeFabricante");
        builder.Property(e => e.PorcentajeMargen).HasColumnName("porcentajeMargen");
        builder.Property(e => e.Porciva).HasColumnName("porciva");
        builder.Property(e => e.SubtotalEjecutado)
            .HasColumnType("money")
            .HasColumnName("subtotalEjecutado");
        builder.Property(e => e.SubtotalPlaneado)
            .HasColumnType("money")
            .HasColumnName("subtotalPlaneado");
        builder.Property(e => e.TotalEjecutado)
            .HasColumnType("money")
            .HasColumnName("totalEjecutado");
        builder.Property(e => e.TotalPlaneado)
            .HasColumnType("money")
            .HasColumnName("totalPlaneado");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ValorUnitarioEjecutado)
            .HasColumnType("money")
            .HasColumnName("valorUnitarioEjecutado");
        builder.Property(e => e.ValorUnitarioPlaneado)
            .HasColumnType("money")
            .HasColumnName("valorUnitarioPlaneado");
        builder.Property(e => e.VencimientoGarantiaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("vencimientoGarantia_ff");
        builder.Property(e => e.Vrbase)
            .HasDefaultValue(0.0)
            .HasColumnName("vrbase");
        builder.Property(e => e.Vrenlista)
            .HasDefaultValue(0.0)
            .HasColumnName("vrenlista");

        builder.HasOne(d => d.IdBodegaNavigation).WithMany(p => p.DocItemDocumentos)
            .HasForeignKey(d => d.IdBodega)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_itemDocumento_id_bodega");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.DocItemDocumentos)
            .HasForeignKey(d => d.IdCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_itemDocumento_id_catalogo");

        builder.HasOne(d => d.IdCentroCostoNavigation).WithMany(p => p.DocItemDocumentos)
            .HasForeignKey(d => d.IdCentroCosto)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_itemDocumento_id_centroCosto");

        builder.HasOne(d => d.IdDocumentoNavigation).WithMany(p => p.DocItemDocumentos)
            .HasForeignKey(d => d.IdDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_itemDocumento_id_documento");

        builder.HasOne(d => d.IdIncotermNavigation).WithMany(p => p.DocItemDocumentos)
            .HasForeignKey(d => d.IdIncoterm)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_itemDocumento_id_incoterm");

        builder.HasOne(d => d.IdItemDocumentoNavigation).WithMany(p => p.InverseIdItemDocumentoNavigation)
            .HasForeignKey(d => d.IdItemDocumento)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_itemDocumento_id_itemDocumento");

        builder.HasOne(d => d.IdItemDocumentoSuperiorNavigation).WithMany(p => p.InverseIdItemDocumentoSuperiorNavigation)
            .HasForeignKey(d => d.IdItemDocumentoSuperior)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_itemDocumento_id_itemDocumento_superior");

        builder.HasOne(d => d.IdListaprecioNavigation).WithMany(p => p.DocItemDocumentos)
            .HasForeignKey(d => d.IdListaprecio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_doc_itemDocumento_id_listaprecio");
    }
}
