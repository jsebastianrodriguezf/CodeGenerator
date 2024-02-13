namespace SAMMAI.DataBase.Repository.Entities;

public partial class GuiAplicacion : GuiAplicacionObject
{
    public virtual ICollection<GuiFuncionalidad> GuiFuncionalidads { get; set; } = new List<GuiFuncionalidad>();
}
