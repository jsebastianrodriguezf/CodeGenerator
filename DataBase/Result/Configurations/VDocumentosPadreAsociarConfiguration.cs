using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class VDocumentosPadreAsociarConfiguration : IEntityTypeConfiguration<VDocumentosPadreAsociar>
{
    public void Configure(EntityTypeBuilder<VDocumentosPadreAsociar> builder)
    {
        builder
            .HasNoKey()
            .ToView("v_documentosPadreAsociar");

        builder.Property(e => e.DocumentoNumero).HasColumnName("documento_numero");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdCliente).HasColumnName("id_cliente");
        builder.Property(e => e.IdEquipo).HasColumnName("id_equipo");
        builder.Property(e => e.IdEstadoTipoDocumento).HasColumnName("id_estadoTipoDocumento");
        builder.Property(e => e.IdSubtipoDocumento).HasColumnName("id_subtipoDocumento");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.Prefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("prefijo");
    }
}
