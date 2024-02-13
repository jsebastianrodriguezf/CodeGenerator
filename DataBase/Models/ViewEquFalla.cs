using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewEquFalla
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Falla { get; set; } = null!;

    public string? FallaCodigo { get; set; }

    public string Procedimiento { get; set; } = null!;

    public int IdTipoFalla { get; set; }

    public string EquTipoFallaTipoFalla { get; set; } = null!;

    public string? EquTipoFallaTipoFallaCodigo { get; set; }

    public int IdFalla { get; set; }

    public string EquFallaPadreFalla { get; set; } = null!;

    public string? EquFallaPadreFallaCodigo { get; set; }

    public string EquFallaPadreProcedimiento { get; set; } = null!;

    public int EquFallaPadreIdTipoFalla { get; set; }

    public int EquFallaPadreIdFalla { get; set; }

    public string Multiempresa { get; set; } = null!;
}
