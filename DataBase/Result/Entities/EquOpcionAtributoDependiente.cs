namespace SAMMAI.DataBase.Repository.Entities;

public partial class EquOpcionAtributoDependiente : EquOpcionAtributoDependienteObject
{
    public virtual EquOpcionAtributo? IdOpcionAtributoHijoNavigation { get; set; }
}
