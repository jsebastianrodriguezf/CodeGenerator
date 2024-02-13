namespace SAMMAI.Transverse.Models.Objects;

public class VChecklistTodaObject
{
    public int Id { get; set; }
    public string Item { get; set; } = null!;
    public string Seccion { get; set; } = null!;
    public int Tipo { get; set; }
    public string? IdsOpciones { get; set; }
    public string? TextosOpciones { get; set; }
    public bool EsVariable { get; set; }
    public int Orden { get; set; }
    public string Rango { get; set; } = null!;
    public bool Obligatorio { get; set; }
    public int IdLista { get; set; }
}
