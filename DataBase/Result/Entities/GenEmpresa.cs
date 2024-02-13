namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenEmpresa : GenEmpresaObject
{
    public virtual ICollection<GenPresupuestoEmpresa> GenPresupuestoEmpresas { get; set; } = new List<GenPresupuestoEmpresa>();
    public virtual GenEmpresa IdEmpresaNavigation { get; set; } = null!;
    public virtual ICollection<GenEmpresa> InverseIdEmpresaNavigation { get; set; } = new List<GenEmpresa>();
}
