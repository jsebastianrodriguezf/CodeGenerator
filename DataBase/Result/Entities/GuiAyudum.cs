namespace SAMMAI.DataBase.Repository.Entities;

public partial class GuiAyudum : GuiAyudumObject
{
    public virtual GuiAyudum IdAyudaNavigation { get; set; } = null!;
    public virtual ICollection<GuiAyudum> InverseIdAyudaNavigation { get; set; } = new List<GuiAyudum>();
}
