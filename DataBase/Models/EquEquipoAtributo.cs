using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquEquipoAtributo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string? EquipoAtributo { get; set; }

    public string? EquipoAtributoCodigo { get; set; }

    public DateTime FechaFf { get; set; }

    public int IdEquipo { get; set; }

    public int IdDocumentoOt { get; set; }

    public int IdAtributo { get; set; }

    public int IdOpcionAtributo { get; set; }

    public int IdReporteTecnico { get; set; }

    public int IdPruebaCheckList { get; set; }

    public int IdEvento { get; set; }

    public virtual CatAtributo IdAtributoNavigation { get; set; } = null!;

    public virtual DocDocumentoOt IdDocumentoOtNavigation { get; set; } = null!;

    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;

    public virtual DisEvento IdEventoNavigation { get; set; } = null!;

    public virtual EquOpcionAtributo IdOpcionAtributoNavigation { get; set; } = null!;

    public virtual OrtReporteTecnico IdReporteTecnicoNavigation { get; set; } = null!;
}
