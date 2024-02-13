using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class SegUsuario
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Usuario { get; set; } = null!;

    public string? UsuarioCodigo { get; set; }

    public int? IntentosFallidos { get; set; }

    public int? NumeroIngresos { get; set; }

    public DateTime? FechaUltimoIngresoFh { get; set; }

    public DateTime? FechaIntentoFallidoFh { get; set; }

    public string? Clave { get; set; }

    public string? Nombre { get; set; }

    public string? Profesion { get; set; }

    public string Email { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Telefono { get; set; }

    public decimal? CostoHora { get; set; }

    public double? PorcentajeComision { get; set; }

    public bool? AccesoActivo { get; set; }

    public bool? CambiarClave { get; set; }

    public DateTime? FechaUltimoCambioClaveFh { get; set; }

    public bool AplicaRecargo { get; set; }

    public bool Sexo { get; set; }

    public int IdPerfil { get; set; }

    public int IdCargo { get; set; }

    public int IdGrupo { get; set; }

    public int IdZona { get; set; }

    public string? Identificacion { get; set; }

    public int IdUsuario { get; set; }

    public byte[]? Preferencias { get; set; }

    public bool Habilitado { get; set; }

    public string? IdDispositivo { get; set; }

    public virtual ICollection<CntContrato> CntContratos { get; set; } = new List<CntContrato>();

    public virtual ICollection<DisEvento> DisEventos { get; set; } = new List<DisEvento>();

    public virtual ICollection<DocDocumentoComentario> DocDocumentoComentarios { get; set; } = new List<DocDocumentoComentario>();

    public virtual ICollection<DocDocumentoCotizacion> DocDocumentoCotizacions { get; set; } = new List<DocDocumentoCotizacion>();

    public virtual ICollection<DocDocumentoEntradum> DocDocumentoEntrada { get; set; } = new List<DocDocumentoEntradum>();

    public virtual ICollection<DocDocumento> DocDocumentoIdUsuarioAsignadoNavigations { get; set; } = new List<DocDocumento>();

    public virtual ICollection<DocDocumento> DocDocumentoIdUsuarioEnUsoNavigations { get; set; } = new List<DocDocumento>();

    public virtual ICollection<DocDocumentoOt> DocDocumentoOts { get; set; } = new List<DocDocumentoOt>();

    public virtual ICollection<DocDocumentoSalidum> DocDocumentoSalida { get; set; } = new List<DocDocumentoSalidum>();

    public virtual ICollection<DocSoporteItemDocumento> DocSoporteItemDocumentos { get; set; } = new List<DocSoporteItemDocumento>();

    public virtual ICollection<EquPrestamo> EquPrestamos { get; set; } = new List<EquPrestamo>();

    public virtual ICollection<GasGasto> GasGastoIdUsuarioAproboNavigations { get; set; } = new List<GasGasto>();

    public virtual ICollection<GasGasto> GasGastoIdUsuarioSolicitanteNavigations { get; set; } = new List<GasGasto>();

    public virtual ICollection<GenBodegaUsuario> GenBodegaUsuarios { get; set; } = new List<GenBodegaUsuario>();

    public virtual ICollection<GenNotificacion> GenNotificacionIdUsuarioDestinoNavigations { get; set; } = new List<GenNotificacion>();

    public virtual ICollection<GenNotificacion> GenNotificacionIdUsuarioOrigenNavigations { get; set; } = new List<GenNotificacion>();

    public virtual SegCargo IdCargoNavigation { get; set; } = null!;

    public virtual SegGrupo IdGrupoNavigation { get; set; } = null!;

    public virtual SegPerfil IdPerfilNavigation { get; set; } = null!;

    public virtual SegUsuario IdUsuarioNavigation { get; set; } = null!;

    public virtual GenZona IdZonaNavigation { get; set; } = null!;

    public virtual ICollection<SegUsuario> InverseIdUsuarioNavigation { get; set; } = new List<SegUsuario>();

    public virtual ICollection<OrtProgramacion> OrtProgramacions { get; set; } = new List<OrtProgramacion>();

    public virtual ICollection<ProEjecutore> ProEjecutores { get; set; } = new List<ProEjecutore>();

    public virtual ICollection<SegRegistroPeticion> SegRegistroPeticions { get; set; } = new List<SegRegistroPeticion>();

    public virtual ICollection<SegUsuarioCatalogoEquipo> SegUsuarioCatalogoEquipos { get; set; } = new List<SegUsuarioCatalogoEquipo>();

    public virtual ICollection<TerContactoEquipo> TerContactoEquipos { get; set; } = new List<TerContactoEquipo>();

    public virtual ICollection<TerContacto> TerContactos { get; set; } = new List<TerContacto>();

    public virtual ICollection<TerSucursal> TerSucursalIdUsuarioAsesorNavigations { get; set; } = new List<TerSucursal>();

    public virtual ICollection<TerSucursal> TerSucursalIdUsuarioTecnicoNavigations { get; set; } = new List<TerSucursal>();

    public virtual ICollection<TerSucursalUsuario> TerSucursalUsuarios { get; set; } = new List<TerSucursalUsuario>();

    public virtual ICollection<TerTerceroUsuario> TerTerceroUsuarios { get; set; } = new List<TerTerceroUsuario>();
}
