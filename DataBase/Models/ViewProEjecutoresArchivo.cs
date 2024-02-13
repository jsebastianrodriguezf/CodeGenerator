using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewProEjecutoresArchivo
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string EjecutoresArchivo { get; set; } = null!;

    public bool? Revisado { get; set; }

    public bool? Aprobado { get; set; }

    public DateTime? FechaRevision { get; set; }

    public DateTime? FechaAprobacion { get; set; }

    public int IdArchivo { get; set; }

    public string GenArchivoArchivo { get; set; } = null!;

    public string? GenArchivoArchivoCodigo { get; set; }

    public string GenArchivoTabla { get; set; } = null!;

    public int GenArchivoIdObjeto { get; set; }

    public string GenArchivoDescripcion { get; set; } = null!;

    public byte[]? GenArchivoArchivoBinario { get; set; }

    public bool? GenArchivoEsPrincipal { get; set; }

    public string? GenArchivoLink { get; set; }

    public int IdEjecutores { get; set; }

    public string ProEjecutoresEjecutores { get; set; } = null!;

    public string? ProEjecutoresEjecutoresCodigo { get; set; }

    public double ProEjecutoresCosto { get; set; }

    public string ProEjecutoresUnidadTiempo { get; set; } = null!;

    public int ProEjecutoresIdHorarioEjecutores { get; set; }

    public int ProEjecutoresIdUsuario { get; set; }

    public string Multiempresa { get; set; } = null!;
}
