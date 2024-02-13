namespace SAMMAI.DataBase.Repository.Entities;

public partial class OrtTipoProgramacion : OrtTipoProgramacionObject
{
    public virtual ICollection<OrtProgramacion> OrtProgramacions { get; set; } = new List<OrtProgramacion>();
}
