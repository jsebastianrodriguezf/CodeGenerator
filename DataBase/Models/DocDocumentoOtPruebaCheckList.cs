using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class DocDocumentoOtPruebaCheckList
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DocumentoOtPruebaCheckList { get; set; } = null!;

    public int IdDocumentoOt { get; set; }

    public int IdPruebaCheckList { get; set; }

    public virtual DocDocumentoOt IdDocumentoOtNavigation { get; set; } = null!;

    public virtual CatPruebaCheckList IdPruebaCheckListNavigation { get; set; } = null!;
}
