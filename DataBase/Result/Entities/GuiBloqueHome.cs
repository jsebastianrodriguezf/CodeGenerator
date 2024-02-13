namespace SAMMAI.DataBase.Repository.Entities;

public partial class GuiBloqueHome : GuiBloqueHomeObject
{
    public virtual ICollection<GuiDetalleBloqueHome> GuiDetalleBloqueHomes { get; set; } = new List<GuiDetalleBloqueHome>();
    public virtual ICollection<SegPerfilBloqueHome> SegPerfilBloqueHomes { get; set; } = new List<SegPerfilBloqueHome>();
}
