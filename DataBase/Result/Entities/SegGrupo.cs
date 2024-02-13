namespace SAMMAI.DataBase.Repository.Entities;

public partial class SegGrupo : SegGrupoObject
{
    public virtual ICollection<SegUsuario> SegUsuarios { get; set; } = new List<SegUsuario>();
}
