using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class SegCargo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Cargo { get; set; } = null!;

    public string? CargoCodigo { get; set; }

    public bool? EsTecnico { get; set; }

    public bool? EsComercial { get; set; }

    public bool? EsCoordinador { get; set; }

    public decimal? ValorHora { get; set; }

    public bool EsAdministrativo { get; set; }

    public virtual ICollection<CatSoporteActividad> CatSoporteActividads { get; set; } = new List<CatSoporteActividad>();

    public virtual ICollection<CatTarifa> CatTarifas { get; set; } = new List<CatTarifa>();

    public virtual ICollection<ComComision> ComComisions { get; set; } = new List<ComComision>();

    public virtual ICollection<DocTarea> DocTareas { get; set; } = new List<DocTarea>();

    public virtual ICollection<SegCargoActividad> SegCargoActividads { get; set; } = new List<SegCargoActividad>();

    public virtual ICollection<SegCargoEnvioCorreo> SegCargoEnvioCorreos { get; set; } = new List<SegCargoEnvioCorreo>();

    public virtual ICollection<SegUsuario> SegUsuarios { get; set; } = new List<SegUsuario>();
}
