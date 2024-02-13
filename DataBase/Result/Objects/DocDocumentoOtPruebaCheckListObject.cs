namespace SAMMAI.Transverse.Models.Objects;

public class DocDocumentoOtPruebaCheckListObject
{
    public int Id { get; set; }
    public string Uid { get; set; } = null!;
    public string Eid { get; set; } = null!;
    public int IdUsuarioModifico { get; set; }
    public int IdUsuarioCreo { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaCreacion { get; set; }
    public bool Active { get; set; }
    public string DocumentoOtPruebaCheckList { get; set; } = null!;
    public int IdDocumentoOt { get; set; }
    public int IdPruebaCheckList { get; set; }
}
