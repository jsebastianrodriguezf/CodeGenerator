namespace SAMMAI.DataBase.Repository.Entities;

public partial class GuiTextoDefecto : GuiTextoDefectoObject
{
    public virtual GuiCampoTexto IdCampoTextoNavigation { get; set; } = null!;
}
