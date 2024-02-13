namespace SAMMAI.Transverse.Models.Objects;

public class ViewGuiTextoDefectoObject
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
    public string GuiCampoTextoCampoTexto { get; set; } = null!;
    public string? GuiCampoTextoCampoTextoCodigo { get; set; }
    public bool GuiCampoTextoEsHtml { get; set; }
    public int GuiCampoTextoIdFuncionalidad { get; set; }
    public string Multiempresa { get; set; } = null!;
}
