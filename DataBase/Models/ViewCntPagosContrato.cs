using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewCntPagosContrato
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string PagosContrato { get; set; } = null!;

    public string? PagosContratoCodigo { get; set; }

    public DateTime FechaFf { get; set; }

    public decimal Valor { get; set; }

    public int IdContrato { get; set; }

    public string CntContratoContrato { get; set; } = null!;

    public string? CntContratoContratoCodigo { get; set; }

    public string CntContratoNumero { get; set; } = null!;

    public decimal? CntContratoTotalContrato { get; set; }

    public decimal? CntContratoPresupuesto { get; set; }

    public DateTime CntContratoFechaInicioFf { get; set; }

    public DateTime? CntContratoFechaFinFf { get; set; }

    public int? CntContratoDiasCumplimiento { get; set; }

    public string? CntContratoCondiciones { get; set; }

    public int CntContratoIdPeriodoContrato { get; set; }

    public int CntContratoIdTercero { get; set; }

    public int CntContratoIdTipoServicio { get; set; }

    public int CntContratoIdTipoContrato { get; set; }

    public int CntContratoIdTerceroServicio { get; set; }

    public int CntContratoIdSubtipoDocumento { get; set; }

    public int CntContratoIdDepartamentoSolicitud { get; set; }

    public int CntContratoIdUsuarioCoordinador { get; set; }

    public string Multiempresa { get; set; } = null!;
}
