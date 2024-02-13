using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewTaxObjetoTax
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ObjetoTax { get; set; } = null!;

    public string? ObjetoTaxCodigo { get; set; }

    public string Tabla { get; set; } = null!;

    public int IdTablaTax { get; set; }

    public int IdTablaTax1 { get; set; }

    public int IdObjTax { get; set; }

    public int IdObjTax1 { get; set; }

    public int IdNivelTax { get; set; }

    public string TaxNivelTaxNivelTax { get; set; } = null!;

    public string? TaxNivelTaxNivelTaxCodigo { get; set; }

    public int TaxNivelTaxIdNivelTax { get; set; }

    public string TaxNivelTaxTabla { get; set; } = null!;

    public string TaxNivelTaxFiltro { get; set; } = null!;

    public string TaxNivelTaxColumnaPrincipal { get; set; } = null!;

    public bool TaxNivelTaxEsEquipo { get; set; }

    public int Orden { get; set; }

    public string Multiempresa { get; set; } = null!;
}
