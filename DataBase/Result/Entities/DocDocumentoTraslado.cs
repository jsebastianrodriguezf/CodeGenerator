namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoTraslado : DocDocumentoTrasladoObject
{
    public virtual GenBodega IdBodegaDestinoNavigation { get; set; } = null!;
    public virtual GenBodega IdBodegaOrigenNavigation { get; set; } = null!;
}
