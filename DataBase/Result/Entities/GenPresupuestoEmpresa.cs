namespace SAMMAI.DataBase.Repository.Entities;

public partial class GenPresupuestoEmpresa : GenPresupuestoEmpresaObject
{
    public virtual GenEmpresa IdEmpresaNavigation { get; set; } = null!;
}
