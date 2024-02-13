using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewGenDetalleFormulario
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string DetalleFormulario { get; set; } = null!;

    public string? DetalleFormularioCodigo { get; set; }

    public string Defecto { get; set; } = null!;

    public bool EsObligatorio { get; set; }

    public int Orden { get; set; }

    public int IdTipoDato { get; set; }

    public string GenTipoDatoTipoDato { get; set; } = null!;

    public string? GenTipoDatoTipoDatoCodigo { get; set; }

    public int? IdColumna { get; set; }

    public string GenColumnaColumna { get; set; } = null!;

    public string? GenColumnaColumnaCodigo { get; set; }

    public bool GenColumnaEsNuleable { get; set; }

    public int? GenColumnaTamano { get; set; }

    public int GenColumnaIdTabla { get; set; }

    public int IdFormulario { get; set; }

    public string GenFormularioFormulario { get; set; } = null!;

    public string? GenFormularioFormularioCodigo { get; set; }

    public int GenFormularioDuplicar { get; set; }

    public int GenFormularioEliminarIntermedias { get; set; }

    public string Multiempresa { get; set; } = null!;
}
