using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GuiBloqueHome
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string BloqueHome { get; set; } = null!;

    public string? BloqueHomeCodigo { get; set; }

    public string NombreControl { get; set; } = null!;

    public string UrlBusqueda { get; set; } = null!;

    public string UrlNuevo { get; set; } = null!;

    public int Orden { get; set; }

    public string ColorModulo { get; set; } = null!;

    public bool EsGenerico { get; set; }

    public string Filtro { get; set; } = null!;

    public bool? Actualizacion { get; set; }

    public virtual ICollection<GuiDetalleBloqueHome> GuiDetalleBloqueHomes { get; set; } = new List<GuiDetalleBloqueHome>();

    public virtual ICollection<SegPerfilBloqueHome> SegPerfilBloqueHomes { get; set; } = new List<SegPerfilBloqueHome>();
}
