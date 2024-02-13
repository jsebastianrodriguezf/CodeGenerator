namespace SAMMAI.Transverse.Models.Objects;

public class GuiTextoDefectoObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string TextoDefecto { get; set; } = null!;
    public string? TextoDefectoCodigo { get; set; }
    public string Texto { get; set; } = null!;
    public int IdCampoTexto { get; set; }
}
