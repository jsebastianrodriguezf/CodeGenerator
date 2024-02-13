namespace SAMMAI.Transverse.Models.Objects;

public class ViewDisEventoEstadoEventoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string EventoEstadoEvento { get; set; } = null!;
    public int IdEvento { get; set; }
    public string DisEventoEvento { get; set; } = null!;
    public string? DisEventoEventoCodigo { get; set; }
    public DateTime DisEventoFechaHoraInicioFf { get; set; }
    public DateTime DisEventoDuracionHh { get; set; }
    public bool DisEventoAfectaProduccion { get; set; }
    public string? DisEventoNotas { get; set; }
    public int DisEventoIdEquipo { get; set; }
    public int DisEventoIdMotivoEvento { get; set; }
    public int DisEventoIdUsuario { get; set; }
    public int DisEventoIdEstadoEquipo { get; set; }
    public int DisEventoIdFalla { get; set; }
    public int DisEventoIdFallaCausa { get; set; }
    public int DisEventoIdMetodoDeteccion { get; set; }
    public DateTime DisEventoFechaHoraEstimadaFh { get; set; }
    public int DisEventoEventoTipo { get; set; }
    public bool DisEventoAfectaCliente { get; set; }
    public int DisEventoIdEstadoEvento { get; set; }
    public int IdEstadoEvento { get; set; }
    public string DisEstadoEventoEstadoEvento { get; set; } = null!;
    public string? DisEstadoEventoEstadoEventoCodigo { get; set; }
    public DateTime FechaHoraRegistroFh { get; set; }
    public bool AfectaCliente { get; set; }
    public int IdSistema { get; set; }
    public string CatSistemaSistema { get; set; } = null!;
    public string? CatSistemaSistemaCodigo { get; set; }
    public int CatSistemaIdSistema { get; set; }
    public string Multiempresa { get; set; } = null!;
}
