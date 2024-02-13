using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewGenEmpresa
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Empresa { get; set; } = null!;

    public string? EmpresaCodigo { get; set; }

    public string Codigo { get; set; } = null!;

    public decimal CostoAdministrativoMes { get; set; }

    public int IdEmpresa { get; set; }

    public string GenEmpresaPadreEmpresa { get; set; } = null!;

    public string? GenEmpresaPadreEmpresaCodigo { get; set; }

    public string GenEmpresaPadreCodigo { get; set; } = null!;

    public decimal GenEmpresaPadreCostoAdministrativoMes { get; set; }

    public int GenEmpresaPadreIdEmpresa { get; set; }

    public string Multiempresa { get; set; } = null!;
}
