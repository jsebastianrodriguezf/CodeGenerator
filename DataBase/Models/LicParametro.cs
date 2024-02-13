using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class LicParametro
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Parametro { get; set; } = null!;

    public string? ParametroCodigo { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<LicCatalogoParametro> LicCatalogoParametros { get; set; } = new List<LicCatalogoParametro>();

    public virtual ICollection<LicLicenciaParametro> LicLicenciaParametros { get; set; } = new List<LicLicenciaParametro>();
}
