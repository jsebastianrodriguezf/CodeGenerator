using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class GenArchivo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Archivo { get; set; } = null!;

    public string? ArchivoCodigo { get; set; }

    public string Tabla { get; set; } = null!;

    public int IdObjeto { get; set; }

    public string Descripcion { get; set; } = null!;

    public byte[]? ArchivoBinario { get; set; }

    public bool? EsPrincipal { get; set; }

    public string? Link { get; set; }

    public int IdTipoArchivo { get; set; }

    public double? Tamano { get; set; }

    public virtual ICollection<ProEjecutoresArchivo> ProEjecutoresArchivos { get; set; } = new List<ProEjecutoresArchivo>();
}
