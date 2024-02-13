namespace SAMMAI.DataBase.Repository.Entities;

public partial class CatDimension : CatDimensionObject
{
    public virtual ICollection<CatPosicion> CatPosicionIdDimensionXNavigations { get; set; } = new List<CatPosicion>();
    public virtual ICollection<CatPosicion> CatPosicionIdDimensionYNavigations { get; set; } = new List<CatPosicion>();
    public virtual ICollection<CatPosicion> CatPosicionIdDimensionZNavigations { get; set; } = new List<CatPosicion>();
}
