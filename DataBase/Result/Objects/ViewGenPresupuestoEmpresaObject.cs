namespace SAMMAI.Transverse.Models.Objects;

public class ViewGenPresupuestoEmpresaObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string PresupuestoEmpresa { get; set; } = null!;
    public string? PresupuestoEmpresaCodigo { get; set; }
    public DateTime FechaInicioFf { get; set; }
    public DateTime FechaFinFf { get; set; }
    public decimal Valor { get; set; }
    public int IdEmpresa { get; set; }
    public string GenEmpresaEmpresa { get; set; } = null!;
    public string? GenEmpresaEmpresaCodigo { get; set; }
    public string GenEmpresaCodigo { get; set; } = null!;
    public decimal GenEmpresaCostoAdministrativoMes { get; set; }
    public int GenEmpresaIdEmpresa { get; set; }
    public string Multiempresa { get; set; } = null!;
}
