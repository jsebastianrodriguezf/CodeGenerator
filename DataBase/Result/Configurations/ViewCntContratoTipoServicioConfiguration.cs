using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCntContratoTipoServicioConfiguration : IEntityTypeConfiguration<ViewCntContratoTipoServicio>
{
    public void Configure(EntityTypeBuilder<ViewCntContratoTipoServicio> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cnt_contrato_tipoServicio");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatListaPrecioEsPrivado).HasColumnName("cat_listaPrecio_esPrivado");
        builder.Property(e => e.CatListaPrecioListaPrecio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_listaPrecio_listaPrecio");
        builder.Property(e => e.CatListaPrecioListaPrecioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_listaPrecio_listaPrecio_codigo");
        builder.Property(e => e.CatListaPrecioPorcentajeDescuento).HasColumnName("cat_listaPrecio_porcentajeDescuento");
        builder.Property(e => e.CntContratoCondiciones)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cnt_contrato_condiciones");
        builder.Property(e => e.CntContratoContrato)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cnt_contrato_contrato");
        builder.Property(e => e.CntContratoContratoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cnt_contrato_contrato_codigo");
        builder.Property(e => e.CntContratoDiasCumplimiento).HasColumnName("cnt_contrato_diasCumplimiento");
        builder.Property(e => e.CntContratoFechaFinFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("cnt_contrato_fechaFin_ff");
        builder.Property(e => e.CntContratoFechaInicioFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("cnt_contrato_fechaInicio_ff");
        builder.Property(e => e.CntContratoIdDepartamentoSolicitud).HasColumnName("cnt_contrato_id_departamentoSolicitud");
        builder.Property(e => e.CntContratoIdDocumentoAlquiler).HasColumnName("cnt_contrato_id_documento.alquiler");
        builder.Property(e => e.CntContratoIdPeriodoContrato).HasColumnName("cnt_contrato_id_periodoContrato");
        builder.Property(e => e.CntContratoIdSubtipoDocumento).HasColumnName("cnt_contrato_id_subtipoDocumento");
        builder.Property(e => e.CntContratoIdTercero).HasColumnName("cnt_contrato_id_tercero");
        builder.Property(e => e.CntContratoIdTerceroServicio).HasColumnName("cnt_contrato_id_tercero_servicio");
        builder.Property(e => e.CntContratoIdTipoContrato).HasColumnName("cnt_contrato_id_tipoContrato");
        builder.Property(e => e.CntContratoIdTipoServicio).HasColumnName("cnt_contrato_id_tipoServicio");
        builder.Property(e => e.CntContratoIdUsuarioCoordinador).HasColumnName("cnt_contrato_id_usuario_coordinador");
        builder.Property(e => e.CntContratoNumero)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cnt_contrato_numero");
        builder.Property(e => e.CntContratoPresupuesto)
            .HasColumnType("money")
            .HasColumnName("cnt_contrato_presupuesto");
        builder.Property(e => e.CntContratoTotalContrato)
            .HasColumnType("money")
            .HasColumnName("cnt_contrato_totalContrato");
        builder.Property(e => e.ContratoTipoServicio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("contrato_tipoServicio");
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
        builder.Property(e => e.GenTipoServicioDiasGarantia).HasColumnName("gen_tipoServicio_diasGarantia");
        builder.Property(e => e.GenTipoServicioTieneGarantia).HasColumnName("gen_tipoServicio_tieneGarantia");
        builder.Property(e => e.GenTipoServicioTipoServicio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_tipoServicio_tipoServicio");
        builder.Property(e => e.GenTipoServicioTipoServicioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_tipoServicio_tipoServicio_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdContrato).HasColumnName("id_contrato");
        builder.Property(e => e.IdListaPrecio).HasColumnName("id_listaPrecio");
        builder.Property(e => e.IdTipoServicio).HasColumnName("id_tipoServicio");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
