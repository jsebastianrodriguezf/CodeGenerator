namespace SAMMAI.Transverse.Models.Objects;

public class GenLocalizacionItemDocumentoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string LocalizacionItemDocumento { get; set; } = null!;
    public int IdLocalizacion { get; set; }
    public int IdItemDocumento { get; set; }
    public int Cantidad { get; set; }
}
