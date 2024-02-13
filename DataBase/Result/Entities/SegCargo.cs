namespace SAMMAI.DataBase.Repository.Entities;

public partial class SegCargo : SegCargoObject
{
    public virtual ICollection<CatSoporteActividad> CatSoporteActividads { get; set; } = new List<CatSoporteActividad>();
    public virtual ICollection<CatTarifa> CatTarifas { get; set; } = new List<CatTarifa>();
    public virtual ICollection<ComComision> ComComisions { get; set; } = new List<ComComision>();
    public virtual ICollection<DocTarea> DocTareas { get; set; } = new List<DocTarea>();
    public virtual ICollection<SegCargoActividad> SegCargoActividads { get; set; } = new List<SegCargoActividad>();
    public virtual ICollection<SegCargoEnvioCorreo> SegCargoEnvioCorreos { get; set; } = new List<SegCargoEnvioCorreo>();
    public virtual ICollection<SegUsuario> SegUsuarios { get; set; } = new List<SegUsuario>();
}
