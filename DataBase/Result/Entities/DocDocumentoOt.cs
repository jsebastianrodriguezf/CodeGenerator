namespace SAMMAI.DataBase.Repository.Entities;

public partial class DocDocumentoOt : DocDocumentoOtObject
{
    public virtual ICollection<CntVisitaFija> CntVisitaFijas { get; set; } = new List<CntVisitaFija>();
    public virtual ICollection<DocDocumentoOtCentroCosto> DocDocumentoOtCentroCostos { get; set; } = new List<DocDocumentoOtCentroCosto>();
    public virtual ICollection<DocDocumentoOtPruebaCheckList> DocDocumentoOtPruebaCheckLists { get; set; } = new List<DocDocumentoOtPruebaCheckList>();
    public virtual ICollection<EquCampanaDocumentoOt> EquCampanaDocumentoOts { get; set; } = new List<EquCampanaDocumentoOt>();
    public virtual ICollection<EquEquipoAtributo> EquEquipoAtributos { get; set; } = new List<EquEquipoAtributo>();
    public virtual ICollection<EquOverhall> EquOverhalls { get; set; } = new List<EquOverhall>();
    public virtual ICollection<GasDocumentoOtDetalleGasto> GasDocumentoOtDetalleGastos { get; set; } = new List<GasDocumentoOtDetalleGasto>();
    public virtual CntContrato IdContratoNavigation { get; set; } = null!;
    public virtual OrtDepartamentoSolicitud IdDepartamentoSolicitudNavigation { get; set; } = null!;
    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;
    public virtual OrtMotivoCancelacion IdMotivoCancelacionNavigation { get; set; } = null!;
    public virtual CatSistema IdSistemaNavigation { get; set; } = null!;
    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;
    public virtual GenTipoServicio IdTipoServicioNavigation { get; set; } = null!;
    public virtual SegUsuario IdUsuarioCoordinadorNavigation { get; set; } = null!;
    public virtual GenZona IdZonaNavigation { get; set; } = null!;
    public virtual ICollection<OrtProgramacion> OrtProgramacions { get; set; } = new List<OrtProgramacion>();
    public virtual ICollection<OrtVale> OrtVales { get; set; } = new List<OrtVale>();
}
