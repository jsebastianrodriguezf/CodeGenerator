using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquCampana
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Campana { get; set; } = null!;

    public string? CampanaCodigo { get; set; }

    public string DetalleCampana { get; set; } = null!;

    public DateTime FechaInicioFf { get; set; }

    public DateTime FechafinFf { get; set; }

    public bool Activo { get; set; }

    public int IdTercero { get; set; }

    public int IdCatalogoTempario { get; set; }

    public virtual ICollection<EquCampanaDocumentoOt> EquCampanaDocumentoOts { get; set; } = new List<EquCampanaDocumentoOt>();

    public virtual CatCatalogoTempario IdCatalogoTemparioNavigation { get; set; } = null!;

    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;
}
