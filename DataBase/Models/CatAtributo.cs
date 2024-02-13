using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatAtributo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Atributo { get; set; } = null!;

    public string? AtributoCodigo { get; set; }

    public string NombreControl { get; set; } = null!;

    public bool EsVariable { get; set; }

    public bool Resaltado { get; set; }

    public double? ValorMinimo { get; set; }

    public double? ValorMaximo { get; set; }

    public int IdSeccionAtributo { get; set; }

    public int IdTipoAtributo { get; set; }

    public int IdUnidad { get; set; }

    public bool EsObligatorio { get; set; }

    public virtual ICollection<CatAtributoOpcionAtributo> CatAtributoOpcionAtributos { get; set; } = new List<CatAtributoOpcionAtributo>();

    public virtual ICollection<CatPruebaCheckListAtributo> CatPruebaCheckListAtributos { get; set; } = new List<CatPruebaCheckListAtributo>();

    public virtual ICollection<CatTarifa> CatTarifas { get; set; } = new List<CatTarifa>();

    public virtual ICollection<DocDocumentoAtributo> DocDocumentoAtributos { get; set; } = new List<DocDocumentoAtributo>();

    public virtual ICollection<EquEquipoAtributo> EquEquipoAtributos { get; set; } = new List<EquEquipoAtributo>();

    public virtual ICollection<EquOpcionAtributo> EquOpcionAtributos { get; set; } = new List<EquOpcionAtributo>();

    public virtual ICollection<GenConfiguracionAtributo> GenConfiguracionAtributos { get; set; } = new List<GenConfiguracionAtributo>();

    public virtual CatSeccionAtributo IdSeccionAtributoNavigation { get; set; } = null!;

    public virtual EquTipoAtributo IdTipoAtributoNavigation { get; set; } = null!;

    public virtual GenUnidad IdUnidadNavigation { get; set; } = null!;
}
