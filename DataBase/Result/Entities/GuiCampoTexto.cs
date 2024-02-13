namespace SAMMAI.DataBase.Repository.Entities;

public partial class GuiCampoTexto : GuiCampoTextoObject
{
    public virtual ICollection<GuiTextoDefecto> GuiTextoDefectos { get; set; } = new List<GuiTextoDefecto>();
    public virtual GuiFuncionalidad IdFuncionalidadNavigation { get; set; } = null!;
}
