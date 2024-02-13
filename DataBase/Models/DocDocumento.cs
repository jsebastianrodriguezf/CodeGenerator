using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumento
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Documento { get; set; } = null!;

    public string? DocumentoCodigo { get; set; }

    public int DocumentoNumero { get; set; }

    public string Prefijo { get; set; } = null!;

    public double Subtotal { get; set; }

    public double Descuento { get; set; }

    public double Iva { get; set; }

    public double Total { get; set; }

    public double Costo { get; set; }

    public double Rentabilidad { get; set; }

    public double Trm { get; set; }

    public DateTime FechaFh { get; set; }

    public DateTime FechaSugeridaFh { get; set; }

    public DateTime FechaCierreFf { get; set; }

    public DateTime FechaLimiteFh { get; set; }

    public int IdSubtipoDocumento { get; set; }

    public int IdTerceroCliente { get; set; }

    public int IdDocumento { get; set; }

    public int IdTerceroProveedor { get; set; }

    public int IdPrioridadDocumento { get; set; }

    public int IdMoneda { get; set; }

    public int IdEstadoTipoDocumento { get; set; }

    public int IdMotivoestado { get; set; }

    public double SubtotalPlaneado { get; set; }

    public double DescuentoPlaneado { get; set; }

    public double IvaPlaneado { get; set; }

    public double TotalPlaneado { get; set; }

    public double CostoPlaneado { get; set; }

    public int IdUsuarioAsignado { get; set; }

    public int IdUsuarioEnUso { get; set; }

    public virtual ICollection<AlqHistoricoAlquiler> AlqHistoricoAlquilers { get; set; } = new List<AlqHistoricoAlquiler>();

    public virtual ICollection<DocDocumentoAtributo> DocDocumentoAtributos { get; set; } = new List<DocDocumentoAtributo>();

    public virtual ICollection<DocDocumentoCatalogoTempario> DocDocumentoCatalogoTemparios { get; set; } = new List<DocDocumentoCatalogoTempario>();

    public virtual ICollection<DocDocumentoComentario> DocDocumentoComentarios { get; set; } = new List<DocDocumentoComentario>();

    public virtual ICollection<DocDocumentoContacto> DocDocumentoContactos { get; set; } = new List<DocDocumentoContacto>();

    public virtual ICollection<DocDocumentoEstadoTipoDocumento> DocDocumentoEstadoTipoDocumentos { get; set; } = new List<DocDocumentoEstadoTipoDocumento>();

    public virtual ICollection<DocDocumentoEvaluacion> DocDocumentoEvaluacions { get; set; } = new List<DocDocumentoEvaluacion>();

    public virtual DocDocumentoGasto? DocDocumentoGasto { get; set; }

    public virtual ICollection<DocDocumentoOpcionRespuestum> DocDocumentoOpcionRespuesta { get; set; } = new List<DocDocumentoOpcionRespuestum>();

    public virtual ICollection<DocItemDocumento> DocItemDocumentos { get; set; } = new List<DocItemDocumento>();

    public virtual ICollection<DocPendienteDocumento> DocPendienteDocumentos { get; set; } = new List<DocPendienteDocumento>();

    public virtual ICollection<EquAlquiler> EquAlquilers { get; set; } = new List<EquAlquiler>();

    public virtual ICollection<EquDetallePagoAlquiler> EquDetallePagoAlquilers { get; set; } = new List<EquDetallePagoAlquiler>();

    public virtual ICollection<EquTrazabilidad> EquTrazabilidads { get; set; } = new List<EquTrazabilidad>();

    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;

    public virtual DocEstadoTipoDocumento IdEstadoTipoDocumentoNavigation { get; set; } = null!;

    public virtual GenMonedum IdMonedaNavigation { get; set; } = null!;

    public virtual DocMotivoestado IdMotivoestadoNavigation { get; set; } = null!;

    public virtual DocPrioridadDocumento IdPrioridadDocumentoNavigation { get; set; } = null!;

    public virtual DocSubtipoDocumento IdSubtipoDocumentoNavigation { get; set; } = null!;

    public virtual TerTercero IdTerceroClienteNavigation { get; set; } = null!;

    public virtual TerTercero IdTerceroProveedorNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioAsignadoNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioEnUsoNavigation { get; set; } = null!;

    public virtual ICollection<DocDocumento> InverseIdDocumentoNavigation { get; set; } = new List<DocDocumento>();
}
