using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CntContrato
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Contrato { get; set; } = null!;

    public string? ContratoCodigo { get; set; }

    public string Numero { get; set; } = null!;

    public decimal? TotalContrato { get; set; }

    public decimal? Presupuesto { get; set; }

    public DateTime FechaInicioFf { get; set; }

    public DateTime? FechaFinFf { get; set; }

    public int? DiasCumplimiento { get; set; }

    public string? Condiciones { get; set; }

    public int IdPeriodoContrato { get; set; }

    public int IdTercero { get; set; }

    public int IdTipoServicio { get; set; }

    public int IdTipoContrato { get; set; }

    public int IdTerceroServicio { get; set; }

    public int IdSubtipoDocumento { get; set; }

    public int IdDepartamentoSolicitud { get; set; }

    public int IdUsuarioCoordinador { get; set; }

    public int IdDocumentoAlquiler { get; set; }

    public int IdEstadoTipoDocumentoInicial { get; set; }

    public int IdSubtipoDocumentoSolicitud { get; set; }

    public virtual ICollection<CntContratoCatalogo> CntContratoCatalogos { get; set; } = new List<CntContratoCatalogo>();

    public virtual ICollection<CntContratoDetalleVisitum> CntContratoDetalleVisita { get; set; } = new List<CntContratoDetalleVisitum>();

    public virtual ICollection<CntContratoEquipo> CntContratoEquipos { get; set; } = new List<CntContratoEquipo>();

    public virtual ICollection<CntContratoSucursal> CntContratoSucursals { get; set; } = new List<CntContratoSucursal>();

    public virtual ICollection<CntContratoTipoServicio> CntContratoTipoServicios { get; set; } = new List<CntContratoTipoServicio>();

    public virtual ICollection<CntContratoZona> CntContratoZonas { get; set; } = new List<CntContratoZona>();

    public virtual ICollection<CntPagosContrato> CntPagosContratos { get; set; } = new List<CntPagosContrato>();

    public virtual ICollection<CntTiempoRespuestum> CntTiempoRespuesta { get; set; } = new List<CntTiempoRespuestum>();

    public virtual ICollection<DocDocumentoOt> DocDocumentoOts { get; set; } = new List<DocDocumentoOt>();

    public virtual OrtDepartamentoSolicitud IdDepartamentoSolicitudNavigation { get; set; } = null!;

    public virtual DocDocumentoAlquiler IdDocumentoAlquilerNavigation { get; set; } = null!;

    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoInicialNavigation { get; set; } = null!;

    public virtual CntPeriodoContrato IdPeriodoContratoNavigation { get; set; } = null!;

    public virtual DocSubtipoDocumento IdSubtipoDocumentoNavigation { get; set; } = null!;

    public virtual DocSubtipoDocumento IdSubtipoDocumentoSolicitudNavigation { get; set; } = null!;

    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;

    public virtual TerTercero IdTerceroServicioNavigation { get; set; } = null!;

    public virtual CntTipoContrato IdTipoContratoNavigation { get; set; } = null!;

    public virtual GenTipoServicio IdTipoServicioNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioCoordinadorNavigation { get; set; } = null!;
}
