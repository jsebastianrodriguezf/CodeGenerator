using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CntVisitaFija
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string VisitaFija { get; set; } = null!;

    public string? VisitaFijaCodigo { get; set; }

    public DateTime FechaFf { get; set; }

    public DateTime FechaCreadaFf { get; set; }

    public double? Horometro { get; set; }

    public int IdDocumentoOt { get; set; }

    public int IdContratoEquipo { get; set; }

    public int IdContratoDetalleVisita { get; set; }

    public int IdCatalogoTempario { get; set; }

    public bool? EsPorTrabajo { get; set; }

    public string CorreoRecordatorio { get; set; } = null!;

    public int? IdConfigContrato { get; set; }

    public double? Presupuesto { get; set; }

    public virtual ICollection<CntCorrimientoVisitaFija> CntCorrimientoVisitaFijas { get; set; } = new List<CntCorrimientoVisitaFija>();

    public virtual ICollection<CntVisitaFijaCatalogo> CntVisitaFijaCatalogos { get; set; } = new List<CntVisitaFijaCatalogo>();

    public virtual CatCatalogoTempario IdCatalogoTemparioNavigation { get; set; } = null!;

    public virtual CntConfigContrato? IdConfigContratoNavigation { get; set; }

    public virtual CntContratoDetalleVisitum IdContratoDetalleVisitaNavigation { get; set; } = null!;

    public virtual CntContratoEquipo IdContratoEquipoNavigation { get; set; } = null!;

    public virtual DocDocumentoOt IdDocumentoOtNavigation { get; set; } = null!;
}
