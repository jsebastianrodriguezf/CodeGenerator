using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GenFamilium
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Familia { get; set; } = null!;

    public string? FamiliaCodigo { get; set; }

    public int IdFamilia { get; set; }

    public virtual ICollection<CatCatalogo> CatCatalogos { get; set; } = new List<CatCatalogo>();

    public virtual ICollection<CatTarifa> CatTarifas { get; set; } = new List<CatTarifa>();

    public virtual ICollection<EquFamiliaFalla> EquFamiliaFallas { get; set; } = new List<EquFamiliaFalla>();

    public virtual GenFamilium IdFamiliaNavigation { get; set; } = null!;

    public virtual ICollection<GenFamilium> InverseIdFamiliaNavigation { get; set; } = new List<GenFamilium>();
}
