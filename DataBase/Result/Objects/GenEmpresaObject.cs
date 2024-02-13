namespace SAMMAI.Transverse.Models.Objects;

public class GenEmpresaObject
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
}
