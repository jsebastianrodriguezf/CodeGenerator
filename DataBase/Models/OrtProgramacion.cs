using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class OrtProgramacion
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Programacion { get; set; } = null!;

    public string? ProgramacionCodigo { get; set; }

    public DateTime? DesdeFh { get; set; }

    public double? Duracion { get; set; }

    public string? Comentario { get; set; }

    public int IdUsuario { get; set; }

    public int IdTipoProgramacion { get; set; }

    public int IdMotivoCancelacion { get; set; }

    public int IdDocumentoOt { get; set; }

    public int IdProgramacion { get; set; }

    public int IdReporteTecnico { get; set; }

    public int IdCatalogoActividad { get; set; }

    public double Costo { get; set; }

    public int IdSoporteItemDocumento { get; set; }

    public virtual CatCatalogoActividad IdCatalogoActividadNavigation { get; set; } = null!;

    public virtual DocDocumentoOt IdDocumentoOtNavigation { get; set; } = null!;

    public virtual OrtMotivoCancelacion IdMotivoCancelacionNavigation { get; set; } = null!;

    public virtual OrtProgramacion IdProgramacionNavigation { get; set; } = null!;

    public virtual OrtReporteTecnico IdReporteTecnicoNavigation { get; set; } = null!;

    public virtual DocSoporteItemDocumento IdSoporteItemDocumentoNavigation { get; set; } = null!;

    public virtual OrtTipoProgramacion IdTipoProgramacionNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<OrtProgramacion> InverseIdProgramacionNavigation { get; set; } = new List<OrtProgramacion>();
}
