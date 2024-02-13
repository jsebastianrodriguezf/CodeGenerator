using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewOrtReporteTecnicoFalla
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string ReporteTecnicoFalla { get; set; } = null!;

    public int IdReporteTecnico { get; set; }

    public string OrtReporteTecnicoReporteTecnico { get; set; } = null!;

    public string? OrtReporteTecnicoReporteTecnicoCodigo { get; set; }

    public string? OrtReporteTecnicoNumero { get; set; }

    public string? OrtReporteTecnicoTrabajos { get; set; }

    public string? OrtReporteTecnicoRecomendaciones { get; set; }

    public string? OrtReporteTecnicoCompromisos { get; set; }

    public int OrtReporteTecnicoIdGasto { get; set; }

    public int? OrtReporteTecnicoIdCanalAtencion { get; set; }

    public int IdFalla { get; set; }

    public string EquFallaFalla { get; set; } = null!;

    public string? EquFallaFallaCodigo { get; set; }

    public string EquFallaProcedimiento { get; set; } = null!;

    public int EquFallaIdTipoFalla { get; set; }

    public int EquFallaIdFalla { get; set; }

    public int IdFallaCausa { get; set; }

    public string EquFallaCausaFalla { get; set; } = null!;

    public string? EquFallaCausaFallaCodigo { get; set; }

    public string EquFallaCausaProcedimiento { get; set; } = null!;

    public int EquFallaCausaIdTipoFalla { get; set; }

    public int EquFallaCausaIdFalla { get; set; }

    public int IdFallaEfecto { get; set; }

    public string EquFallaEfectoFalla { get; set; } = null!;

    public string? EquFallaEfectoFallaCodigo { get; set; }

    public string EquFallaEfectoProcedimiento { get; set; } = null!;

    public int EquFallaEfectoIdTipoFalla { get; set; }

    public int EquFallaEfectoIdFalla { get; set; }

    public string Multiempresa { get; set; } = null!;
}
