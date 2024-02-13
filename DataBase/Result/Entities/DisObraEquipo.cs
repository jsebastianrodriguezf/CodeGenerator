namespace SAMMAI.DataBase.Repository.Entities;

public partial class DisObraEquipo : DisObraEquipoObject
{
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
    public virtual DisObra IdObraNavigation { get; set; } = null!;
}
