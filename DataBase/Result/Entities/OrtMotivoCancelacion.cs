namespace SAMMAI.DataBase.Repository.Entities;

public partial class OrtMotivoCancelacion : OrtMotivoCancelacionObject
{
    public virtual ICollection<DocDocumentoOt> DocDocumentoOts { get; set; } = new List<DocDocumentoOt>();
    public virtual ICollection<OrtProgramacion> OrtProgramacions { get; set; } = new List<OrtProgramacion>();
}
