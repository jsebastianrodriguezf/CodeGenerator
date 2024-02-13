namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProRolContacto : ProRolContactoObject
{
    public virtual TerContacto IdContactoNavigation { get; set; } = null!;
    public virtual ProRol IdRolNavigation { get; set; } = null!;
}
