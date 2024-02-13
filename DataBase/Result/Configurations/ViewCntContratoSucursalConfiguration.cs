using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewCntContratoSucursalConfiguration : IEntityTypeConfiguration<ViewCntContratoSucursal>
{
    public void Configure(EntityTypeBuilder<ViewCntContratoSucursal> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_cnt_contrato_sucursal");

        builder.Property(e => e.Active).HasColumnName("active");
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
        builder.Property(e => e.ContratoSucursal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("contrato_sucursal");
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
        builder.Property(e => e.IdContrato).HasColumnName("id_contrato");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.PrecioServicio)
            .HasColumnType("money")
            .HasColumnName("precioServicio");
        builder.Property(e => e.PrecioVisita)
            .HasColumnType("money")
            .HasColumnName("precioVisita");
        builder.Property(e => e.Presupuesto)
            .HasColumnType("money")
            .HasColumnName("presupuesto");
        builder.Property(e => e.TerSucursalCodigorecursiva)
            .HasMaxLength(5000)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_codigorecursiva");
        builder.Property(e => e.TerSucursalContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_contacto");
        builder.Property(e => e.TerSucursalDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Direccion");
        builder.Property(e => e.TerSucursalEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Email");
        builder.Property(e => e.TerSucursalFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_Fax");
        builder.Property(e => e.TerSucursalIdEstadoTercero).HasColumnName("ter_sucursal_id_estadoTercero");
        builder.Property(e => e.TerSucursalIdSucursal).HasColumnName("ter_sucursal_id_sucursal");
        builder.Property(e => e.TerSucursalIdTercero).HasColumnName("ter_sucursal_id_tercero");
        builder.Property(e => e.TerSucursalIdUsuarioAsesor).HasColumnName("ter_sucursal_id_usuario_asesor");
        builder.Property(e => e.TerSucursalIdUsuarioTecnico).HasColumnName("ter_sucursal_id_usuario_tecnico");
        builder.Property(e => e.TerSucursalIdZona).HasColumnName("ter_sucursal_id_zona");
        builder.Property(e => e.TerSucursalParaAlquiler).HasColumnName("ter_sucursal_paraAlquiler");
        builder.Property(e => e.TerSucursalParaSoporte).HasColumnName("ter_sucursal_paraSoporte");
        builder.Property(e => e.TerSucursalParaVenta).HasColumnName("ter_sucursal_paraVenta");
        builder.Property(e => e.TerSucursalSucursal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_sucursal");
        builder.Property(e => e.TerSucursalSucursalCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_sucursal_codigo");
        builder.Property(e => e.TerSucursalTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_sucursal_telefono");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
