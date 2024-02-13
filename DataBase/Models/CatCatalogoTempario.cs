using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatCatalogoTempario
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CatalogoTempario { get; set; } = null!;

    public double? DuracionEstimada { get; set; }

    public bool EnTaller { get; set; }

    public bool EsCiclico { get; set; }

    public bool DetieneEquipos { get; set; }

    public double? HorasDetencion { get; set; }

    public int PeriodoHoras { get; set; }

    public bool FacturaTodo { get; set; }

    public int PeriodoDias { get; set; }

    public double PorcGarantia { get; set; }

    public double PorcTropicalizacion { get; set; }

    public int IdTipoServicio { get; set; }

    public bool Proyectar { get; set; }

    public bool IncluirMenores { get; set; }

    public int ModoAjuste { get; set; }

    public virtual ICollection<CatCatalogoEquipoCatalogoTempario> CatCatalogoEquipoCatalogoTemparios { get; set; } = new List<CatCatalogoEquipoCatalogoTempario>();

    public virtual ICollection<CatDetalleTempario> CatDetalleTemparios { get; set; } = new List<CatDetalleTempario>();

    public virtual ICollection<CntConfigContrato> CntConfigContratos { get; set; } = new List<CntConfigContrato>();

    public virtual ICollection<CntVisitaFija> CntVisitaFijas { get; set; } = new List<CntVisitaFija>();

    public virtual ICollection<DocDocumentoCatalogoTempario> DocDocumentoCatalogoTemparios { get; set; } = new List<DocDocumentoCatalogoTempario>();

    public virtual ICollection<EquCampana> EquCampanas { get; set; } = new List<EquCampana>();

    public virtual GenTipoServicio IdTipoServicioNavigation { get; set; } = null!;
}
