namespace SAMMAI.Transverse.Models.Objects;

public class CntContratoTipoServicioObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string ContratoTipoServicio { get; set; } = null!;
    public int IdContrato { get; set; }
    public int IdTipoServicio { get; set; }
    public int IdListaPrecio { get; set; }
}
