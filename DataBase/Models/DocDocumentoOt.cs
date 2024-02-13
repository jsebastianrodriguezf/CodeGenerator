using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumentoOt
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoOt { get; set; } = null!;

    public string MotivoServicio { get; set; } = null!;

    public bool EnTaller { get; set; }

    public string? DiagnosticoInicial { get; set; }

    public string Contacto { get; set; } = null!;

    public string? Cargo { get; set; }

    public string Telefono { get; set; } = null!;

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? DireccionUbicacion { get; set; }

    public double DuracionEstimada { get; set; }

    public DateTime? FechaGarantiaFf { get; set; }

    public DateTime FechaCompromisoFh { get; set; }

    public string? Trabajos { get; set; }

    public string? Recomendaciones { get; set; }

    public string? Compromisos { get; set; }

    public string? ReclamacionFabrica { get; set; }

    public double? PorcentajeCliente { get; set; }

    public double? PorcentajeDistribuidor { get; set; }

    public double? PorcentajeFabricante { get; set; }

    public bool? SegunTempario { get; set; }

    public bool? DistribuyeCentros { get; set; }

    public int IdTipoServicio { get; set; }

    public int IdEquipo { get; set; }

    public int IdUsuarioCoordinador { get; set; }

    public int IdMotivoCancelacion { get; set; }

    public int IdSucursal { get; set; }

    public int IdSistema { get; set; }

    public int IdDepartamentoSolicitud { get; set; }

    public int IdContrato { get; set; }

    public int IdZona { get; set; }

    public virtual ICollection<CntVisitaFija> CntVisitaFijas { get; set; } = new List<CntVisitaFija>();

    public virtual ICollection<DocDocumentoOtCentroCosto> DocDocumentoOtCentroCostos { get; set; } = new List<DocDocumentoOtCentroCosto>();

    public virtual ICollection<DocDocumentoOtPruebaCheckList> DocDocumentoOtPruebaCheckLists { get; set; } = new List<DocDocumentoOtPruebaCheckList>();

    public virtual ICollection<EquCampanaDocumentoOt> EquCampanaDocumentoOts { get; set; } = new List<EquCampanaDocumentoOt>();

    public virtual ICollection<EquEquipoAtributo> EquEquipoAtributos { get; set; } = new List<EquEquipoAtributo>();

    public virtual ICollection<EquOverhall> EquOverhalls { get; set; } = new List<EquOverhall>();

    public virtual ICollection<GasDocumentoOtDetalleGasto> GasDocumentoOtDetalleGastos { get; set; } = new List<GasDocumentoOtDetalleGasto>();

    public virtual CntContrato IdContratoNavigation { get; set; } = null!;

    public virtual OrtDepartamentoSolicitud IdDepartamentoSolicitudNavigation { get; set; } = null!;

    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;

    public virtual OrtMotivoCancelacion IdMotivoCancelacionNavigation { get; set; } = null!;

    public virtual CatSistema IdSistemaNavigation { get; set; } = null!;

    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;

    public virtual GenTipoServicio IdTipoServicioNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioCoordinadorNavigation { get; set; } = null!;

    public virtual GenZona IdZonaNavigation { get; set; } = null!;

    public virtual ICollection<OrtProgramacion> OrtProgramacions { get; set; } = new List<OrtProgramacion>();

    public virtual ICollection<OrtVale> OrtVales { get; set; } = new List<OrtVale>();
}
