namespace SAMMAI.DataBase.Repository.Entities;

public partial class GuiDetalleBloqueHome : GuiDetalleBloqueHomeObject
{
    public virtual GuiBloqueHome IdBloqueHomeNavigation { get; set; } = null!;
}
