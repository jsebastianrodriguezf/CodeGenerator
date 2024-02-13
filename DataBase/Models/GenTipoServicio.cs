using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GenTipoServicio
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string TipoServicio { get; set; } = null!;

    public string? TipoServicioCodigo { get; set; }

    public bool? TieneGarantia { get; set; }

    public int? DiasGarantia { get; set; }

    public virtual ICollection<CatCatalogoTempario> CatCatalogoTemparios { get; set; } = new List<CatCatalogoTempario>();

    public virtual ICollection<CatTarifa> CatTarifas { get; set; } = new List<CatTarifa>();

    public virtual ICollection<CntContratoTipoServicio> CntContratoTipoServicios { get; set; } = new List<CntContratoTipoServicio>();

    public virtual ICollection<CntContrato> CntContratos { get; set; } = new List<CntContrato>();

    public virtual ICollection<DocDocumentoOt> DocDocumentoOts { get; set; } = new List<DocDocumentoOt>();

    public virtual ICollection<GenConfiguracionServicio> GenConfiguracionServicios { get; set; } = new List<GenConfiguracionServicio>();

    public virtual ICollection<SegUsuarioCatalogoEquipo> SegUsuarioCatalogoEquipos { get; set; } = new List<SegUsuarioCatalogoEquipo>();
}
