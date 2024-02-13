using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatCatalogoRepuesto
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string CatalogoRepuesto { get; set; } = null!;

    public int? GarantiaDias { get; set; }

    public int? GarantiaHoras { get; set; }

    public bool Vigente { get; set; }

    public int IdMarca { get; set; }

    public double? Peso { get; set; }

    public virtual ICollection<CatDetalleRepuesto> CatDetalleRepuestoIdCatalogoRepuestoHijoNavigations { get; set; } = new List<CatDetalleRepuesto>();

    public virtual ICollection<CatDetalleRepuesto> CatDetalleRepuestoIdCatalogoRepuestoNavigations { get; set; } = new List<CatDetalleRepuesto>();

    public virtual ICollection<CatReemplazo> CatReemplazoIdCatalogoRepuesto1Navigations { get; set; } = new List<CatReemplazo>();

    public virtual ICollection<CatReemplazo> CatReemplazoIdCatalogoRepuestoNavigations { get; set; } = new List<CatReemplazo>();

    public virtual CatMarca IdMarcaNavigation { get; set; } = null!;
}
