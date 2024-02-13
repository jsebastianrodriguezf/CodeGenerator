using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewGenConfiguracionAtributo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ConfiguracionAtributos { get; set; } = null!;

    public string? ConfiguracionAtributosCodigo { get; set; }

    public int Orden { get; set; }

    public bool EsObligatorio { get; set; }

    public bool EsResaltado { get; set; }

    public string Defecto { get; set; } = null!;

    public int IdAtributo { get; set; }

    public string CatAtributoAtributo { get; set; } = null!;

    public string? CatAtributoAtributoCodigo { get; set; }

    public string CatAtributoNombreControl { get; set; } = null!;

    public bool CatAtributoEsVariable { get; set; }

    public bool CatAtributoResaltado { get; set; }

    public double? CatAtributoValorMinimo { get; set; }

    public double? CatAtributoValorMaximo { get; set; }

    public int CatAtributoIdSeccionAtributo { get; set; }

    public int CatAtributoIdTipoAtributo { get; set; }

    public int CatAtributoIdUnidad { get; set; }

    public bool CatAtributoEsObligatorio { get; set; }

    public int IdFormulario { get; set; }

    public string GenFormularioFormulario { get; set; } = null!;

    public string? GenFormularioFormularioCodigo { get; set; }

    public int GenFormularioDuplicar { get; set; }

    public int GenFormularioEliminarIntermedias { get; set; }

    public int? IdTablaResultado { get; set; }

    public int? IdTablaRelacion { get; set; }

    public string Multiempresa { get; set; } = null!;
}
