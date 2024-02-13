namespace SAMMAI.DataBase.Repository.Entities;

public partial class GuiFuncionalidad : GuiFuncionalidadObject
{
    public virtual ICollection<GuiCampoTexto> GuiCampoTextos { get; set; } = new List<GuiCampoTexto>();
    public virtual GuiAplicacion IdAplicacionNavigation { get; set; } = null!;
    public virtual GuiFuncionalidad IdFuncionalidadNavigation { get; set; } = null!;
    public virtual GuiTipoFuncionalidad IdTipoFuncionalidadNavigation { get; set; } = null!;
    public virtual ICollection<GuiFuncionalidad> InverseIdFuncionalidadNavigation { get; set; } = new List<GuiFuncionalidad>();
    public virtual ICollection<RepReporte> RepReportes { get; set; } = new List<RepReporte>();
    public virtual ICollection<SegPerfilFuncionalidad> SegPerfilFuncionalidads { get; set; } = new List<SegPerfilFuncionalidad>();
}
