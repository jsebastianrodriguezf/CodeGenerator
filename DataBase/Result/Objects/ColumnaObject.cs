namespace SAMMAI.Transverse.Models.Objects;

public class ColumnaObject
{
    public int Id { get; set; }
    public string Columna1 { get; set; } = null!;
    public string Tipo { get; set; } = null!;
    public int Tamano { get; set; }
    public bool EsNuleable { get; set; }
    public int IdTabla { get; set; }
}
