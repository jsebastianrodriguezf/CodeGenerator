using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class EquTrazabilidad
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Trazabilidad { get; set; } = null!;

    public string? TrazabilidadCodigo { get; set; }

    public double? Horometro { get; set; }

    public DateTime FechaFf { get; set; }

    public bool EsSoporte { get; set; }

    public int IdEquipo { get; set; }

    public int IdEquipoPadre { get; set; }

    public int IdTercero { get; set; }

    public int IdSucursal { get; set; }

    public int IdDocumentoAlquiler { get; set; }

    public int IdPrestamo { get; set; }

    public int IdReporteTecnico { get; set; }

    public int IdEvento { get; set; }

    public int IdDocumento { get; set; }

    public int IdTipoTrazabilidad { get; set; }

    public int IdCicloHorometro { get; set; }

    public int IdPosicion { get; set; }

    public int IdEstadoEquipo { get; set; }

    public virtual EquCicloHorometro IdCicloHorometroNavigation { get; set; } = null!;

    public virtual DocDocumentoAlquiler IdDocumentoAlquilerNavigation { get; set; } = null!;

    public virtual DocDocumento IdDocumentoNavigation { get; set; } = null!;

    public virtual EquEquipo IdEquipoNavigation { get; set; } = null!;

    public virtual EquEquipo IdEquipoPadreNavigation { get; set; } = null!;

    public virtual DisEvento IdEventoNavigation { get; set; } = null!;

    public virtual CatPosicion IdPosicionNavigation { get; set; } = null!;

    public virtual EquPrestamo IdPrestamoNavigation { get; set; } = null!;

    public virtual OrtReporteTecnico IdReporteTecnicoNavigation { get; set; } = null!;

    public virtual TerSucursal IdSucursalNavigation { get; set; } = null!;

    public virtual TerTercero IdTerceroNavigation { get; set; } = null!;

    public virtual EquTipoTrazabilidad IdTipoTrazabilidadNavigation { get; set; } = null!;
}
