using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class VDocumentosPadreAsociar
{
    public int Id { get; set; }

    public string Prefijo { get; set; } = null!;

    public int DocumentoNumero { get; set; }

    public int IdSubtipoDocumento { get; set; }

    public int IdEstadoTipoDocumento { get; set; }

    public int IdCliente { get; set; }

    public int? IdSucursal { get; set; }

    public int? IdEquipo { get; set; }
}
