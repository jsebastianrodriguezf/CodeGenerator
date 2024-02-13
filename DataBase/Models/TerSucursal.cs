using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class TerSucursal
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Sucursal { get; set; } = null!;

    public string? SucursalCodigo { get; set; }

    public string? Contacto { get; set; }

    public string Telefono { get; set; } = null!;

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Direccion { get; set; }

    public bool ParaVenta { get; set; }

    public bool ParaSoporte { get; set; }

    public bool ParaAlquiler { get; set; }

    public int IdTercero { get; set; }

    public int IdZona { get; set; }

    public int IdUsuarioAsesor { get; set; }

    public int IdUsuarioTecnico { get; set; }

    public int IdSucursal { get; set; }

    public int IdEstadoTercero { get; set; }

    public string? Codigorecursiva { get; set; }

    public string Cargo { get; set; } = null!;

    public virtual ICollection<CntContratoSucursal> CntContratoSucursals { get; set; } = new List<CntContratoSucursal>();

    public virtual ICollection<DisObra> DisObras { get; set; } = new List<DisObra>();

    public virtual ICollection<DocDocumentoCotizacion> DocDocumentoCotizacions { get; set; } = new List<DocDocumentoCotizacion>();

    public virtual ICollection<DocDocumentoEntradum> DocDocumentoEntrada { get; set; } = new List<DocDocumentoEntradum>();

    public virtual ICollection<DocDocumentoOrdenCompra> DocDocumentoOrdenCompras { get; set; } = new List<DocDocumentoOrdenCompra>();

    public virtual ICollection<DocDocumentoOt> DocDocumentoOts { get; set; } = new List<DocDocumentoOt>();

    public virtual ICollection<DocDocumentoProyectoSucursal> DocDocumentoProyectoSucursals { get; set; } = new List<DocDocumentoProyectoSucursal>();

    public virtual ICollection<DocDocumentoRequisicion> DocDocumentoRequisicions { get; set; } = new List<DocDocumentoRequisicion>();

    public virtual ICollection<DocDocumentoSalidum> DocDocumentoSalida { get; set; } = new List<DocDocumentoSalidum>();

    public virtual ICollection<DocDocumentoSolicitud> DocDocumentoSolicituds { get; set; } = new List<DocDocumentoSolicitud>();

    public virtual ICollection<EquAlquiler> EquAlquilers { get; set; } = new List<EquAlquiler>();

    public virtual ICollection<EquDetalleAlquiler> EquDetalleAlquilers { get; set; } = new List<EquDetalleAlquiler>();

    public virtual ICollection<EquEquipo> EquEquipos { get; set; } = new List<EquEquipo>();

    public virtual ICollection<EquTrazabilidad> EquTrazabilidads { get; set; } = new List<EquTrazabilidad>();

    public virtual ICollection<GenBodega> GenBodegas { get; set; } = new List<GenBodega>();

    public virtual TerEstadoTercero IdEstadoTerceroNavigation { get; set; } = null!;

    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;

    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioAsesorNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioTecnicoNavigation { get; set; } = null!;

    public virtual GenZona IdZonaNavigation { get; set; } = null!;

    public virtual ICollection<TerSucursal> InverseIdSucursalNavigation { get; set; } = new List<TerSucursal>();

    public virtual ICollection<ProReporteActividad> ProReporteActividads { get; set; } = new List<ProReporteActividad>();

    public virtual ICollection<TerContactoSucursal> TerContactoSucursals { get; set; } = new List<TerContactoSucursal>();

    public virtual ICollection<TerSucursalListaprecio> TerSucursalListaprecios { get; set; } = new List<TerSucursalListaprecio>();

    public virtual ICollection<TerSucursalUsuario> TerSucursalUsuarios { get; set; } = new List<TerSucursalUsuario>();
}
