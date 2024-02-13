namespace SAMMAI.DataBase.Repository.Entities;

public partial class GuiTipoFuncionalidad : GuiTipoFuncionalidadObject
{
    public virtual ICollection<GuiFuncionalidad> GuiFuncionalidads { get; set; } = new List<GuiFuncionalidad>();
}
