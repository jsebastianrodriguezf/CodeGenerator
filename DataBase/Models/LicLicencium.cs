using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class LicLicencium
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Licencia { get; set; } = null!;

    public string? LicenciaCodigo { get; set; }

    public string Serial { get; set; } = null!;

    public string Clave { get; set; } = null!;

    public DateTime FechaInicioFf { get; set; }

    public DateTime FechaFinFf { get; set; }

    public int IdTercero { get; set; }

    public int IdCatalogo { get; set; }

    public virtual CatCatalogo IdCatalogoNavigation { get; set; } = null!;

    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;

    public virtual ICollection<LicLicenciaParametro> LicLicenciaParametros { get; set; } = new List<LicLicenciaParametro>();
}
