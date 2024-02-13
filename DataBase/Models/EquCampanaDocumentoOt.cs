using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquCampanaDocumentoOt
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CampanaDocumentoOt { get; set; } = null!;

    public int IdCampana { get; set; }

    public int IdDocumentoOt { get; set; }

    public virtual EquCampana IdCampanaNavigation { get; set; } = null!;

    public virtual DocDocumentoOt IdDocumentoOtNavigation { get; set; } = null!;
}
