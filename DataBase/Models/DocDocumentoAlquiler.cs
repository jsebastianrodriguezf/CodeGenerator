using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumentoAlquiler
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoAlquiler { get; set; } = null!;

    public DateTime? FechaFinFf { get; set; }

    public bool MesVencido { get; set; }

    public string? Observaciones { get; set; }

    public bool EjecutaDevolucion { get; set; }

    public virtual ICollection<CntContrato> CntContratos { get; set; } = new List<CntContrato>();

    public virtual ICollection<EquDetalleAlquiler> EquDetalleAlquilers { get; set; } = new List<EquDetalleAlquiler>();

    public virtual ICollection<EquPagoAlquiler> EquPagoAlquilers { get; set; } = new List<EquPagoAlquiler>();

    public virtual ICollection<EquTrazabilidad> EquTrazabilidads { get; set; } = new List<EquTrazabilidad>();
}
