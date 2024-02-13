using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class ViewSegPerfil
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Perfil { get; set; } = null!;

    public string? PerfilCodigo { get; set; }

    public string? Descripcion { get; set; }

    public bool? MostrarBotones { get; set; }

    public bool? ParaCliente { get; set; }

    public bool? ParaProveedor { get; set; }

    public string Multiempresa { get; set; } = null!;
}
