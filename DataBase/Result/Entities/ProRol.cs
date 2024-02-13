namespace SAMMAI.DataBase.Repository.Entities;

public partial class ProRol : ProRolObject
{
    public virtual ICollection<ProRolContacto> ProRolContactos { get; set; } = new List<ProRolContacto>();
}
