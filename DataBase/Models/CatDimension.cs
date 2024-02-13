using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatDimension
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Dimension { get; set; } = null!;

    public string? DimensionCodigo { get; set; }

    public bool AplicaEnX { get; set; }

    public bool AplicaEnY { get; set; }

    public bool AplicaEnZ { get; set; }

    public virtual ICollection<CatPosicion> CatPosicionIdDimensionXNavigations { get; set; } = new List<CatPosicion>();

    public virtual ICollection<CatPosicion> CatPosicionIdDimensionYNavigations { get; set; } = new List<CatPosicion>();

    public virtual ICollection<CatPosicion> CatPosicionIdDimensionZNavigations { get; set; } = new List<CatPosicion>();
}
