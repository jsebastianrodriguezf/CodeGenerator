using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class TaxNivelTax
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string NivelTax { get; set; } = null!;

    public string? NivelTaxCodigo { get; set; }

    public int IdNivelTax { get; set; }

    public string Tabla { get; set; } = null!;

    public string Filtro { get; set; } = null!;

    public string ColumnaPrincipal { get; set; } = null!;

    public bool EsEquipo { get; set; }

    public virtual TaxNivelTax IdNivelTaxNavigation { get; set; } = null!;

    public virtual ICollection<TaxNivelTax> InverseIdNivelTaxNavigation { get; set; } = new List<TaxNivelTax>();

    public virtual ICollection<TaxObjetoTax> TaxObjetoTaxes { get; set; } = new List<TaxObjetoTax>();
}
