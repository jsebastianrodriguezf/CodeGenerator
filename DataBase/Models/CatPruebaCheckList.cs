using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class CatPruebaCheckList
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string PruebaCheckList { get; set; } = null!;

    public string? PruebaCheckListCodigo { get; set; }

    public bool Activo { get; set; }

    public virtual ICollection<CatCatalogoEquipoPruebaCheckList> CatCatalogoEquipoPruebaCheckLists { get; set; } = new List<CatCatalogoEquipoPruebaCheckList>();

    public virtual ICollection<CatDetalleTempario> CatDetalleTemparios { get; set; } = new List<CatDetalleTempario>();

    public virtual ICollection<CatPruebaCheckListAtributo> CatPruebaCheckListAtributos { get; set; } = new List<CatPruebaCheckListAtributo>();

    public virtual ICollection<DocDocumentoOtPruebaCheckList> DocDocumentoOtPruebaCheckLists { get; set; } = new List<DocDocumentoOtPruebaCheckList>();
}
