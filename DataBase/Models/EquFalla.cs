using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquFalla
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Falla { get; set; } = null!;

    public string? FallaCodigo { get; set; }

    public string Procedimiento { get; set; } = null!;

    public int IdTipoFalla { get; set; }

    public int IdFalla { get; set; }

    public virtual ICollection<DisEvento> DisEventoIdFallaCausaNavigations { get; set; } = new List<DisEvento>();

    public virtual ICollection<DisEvento> DisEventoIdFallaNavigations { get; set; } = new List<DisEvento>();

    public virtual ICollection<EquAnalisisFalla> EquAnalisisFallaIdFallaCausaNavigations { get; set; } = new List<EquAnalisisFalla>();

    public virtual ICollection<EquAnalisisFalla> EquAnalisisFallaIdFallaEfectoNavigations { get; set; } = new List<EquAnalisisFalla>();

    public virtual ICollection<EquAnalisisFalla> EquAnalisisFallaIdFallaNavigations { get; set; } = new List<EquAnalisisFalla>();

    public virtual ICollection<EquAnalisisFalla> EquAnalisisFallaIdFallaSolucionNavigations { get; set; } = new List<EquAnalisisFalla>();

    public virtual ICollection<EquFamiliaFalla> EquFamiliaFallas { get; set; } = new List<EquFamiliaFalla>();

    public virtual EquFalla IdFallaNavigation { get; set; } = null!;

    public virtual EquTipoFalla IdTipoFallaNavigation { get; set; } = null!;

    public virtual ICollection<EquFalla> InverseIdFallaNavigation { get; set; } = new List<EquFalla>();

    public virtual ICollection<OrtReporteTecnicoFalla> OrtReporteTecnicoFallaIdFallaCausaNavigations { get; set; } = new List<OrtReporteTecnicoFalla>();

    public virtual ICollection<OrtReporteTecnicoFalla> OrtReporteTecnicoFallaIdFallaEfectoNavigations { get; set; } = new List<OrtReporteTecnicoFalla>();

    public virtual ICollection<OrtReporteTecnicoFalla> OrtReporteTecnicoFallaIdFallaNavigations { get; set; } = new List<OrtReporteTecnicoFalla>();
}
