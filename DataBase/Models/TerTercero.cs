using System;
using System.Collections.Generic;

namespace SAMMAI.DataBase;

public partial class TerTercero
{
    public int Id { get; set; }

    public string Uid { get; set; } = null!;

    public string Eid { get; set; } = null!;

    public int IdUsuarioModifico { get; set; }

    public int IdUsuarioCreo { get; set; }

    public DateTime FechaModificacion { get; set; }

    public DateTime FechaCreacion { get; set; }

    public bool Active { get; set; }

    public string Tercero { get; set; } = null!;

    public string? TerceroCodigo { get; set; }

    public string TerceroNit { get; set; } = null!;

    public string? Direccion { get; set; }

    public string? Contacto { get; set; }

    public string Telefono { get; set; } = null!;

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public string? Representante { get; set; }

    public string? Notas { get; set; }

    public string TerceroNombreCorto { get; set; } = null!;

    public bool EsCliente { get; set; }

    public bool EsProveedor { get; set; }

    public bool EsTransportador { get; set; }

    public bool EsFabricante { get; set; }

    public bool EsEmpresaPropia { get; set; }

    public string? Clasificacion { get; set; }

    public int IdZona { get; set; }

    public int IdEstadoTercero { get; set; }

    public int IdNaturalezaTercero { get; set; }

    public bool EsProspecto { get; set; }

    public int? IdFormaPago { get; set; }

    public int? TiempoEntrega { get; set; }

    public virtual ICollection<CatMarca> CatMarcas { get; set; } = new List<CatMarca>();

    public virtual ICollection<CntConfigContrato> CntConfigContratos { get; set; } = new List<CntConfigContrato>();

    public virtual ICollection<CntContrato> CntContratoIdTerceroNavigations { get; set; } = new List<CntContrato>();

    public virtual ICollection<CntContrato> CntContratoIdTerceroServicioNavigations { get; set; } = new List<CntContrato>();

    public virtual ICollection<DocDocumentoEntradum> DocDocumentoEntrada { get; set; } = new List<DocDocumentoEntradum>();

    public virtual ICollection<DocDocumento> DocDocumentoIdTerceroClienteNavigations { get; set; } = new List<DocDocumento>();

    public virtual ICollection<DocDocumento> DocDocumentoIdTerceroProveedorNavigations { get; set; } = new List<DocDocumento>();

    public virtual ICollection<DocDocumentoSalidum> DocDocumentoSalida { get; set; } = new List<DocDocumentoSalidum>();

    public virtual ICollection<EquAlquiler> EquAlquilers { get; set; } = new List<EquAlquiler>();

    public virtual ICollection<EquCampana> EquCampanas { get; set; } = new List<EquCampana>();

    public virtual ICollection<EquDetalleAlquiler> EquDetalleAlquilers { get; set; } = new List<EquDetalleAlquiler>();

    public virtual ICollection<EquEquipo> EquEquipoIdTerceroCompradorNavigations { get; set; } = new List<EquEquipo>();

    public virtual ICollection<EquEquipo> EquEquipoIdTerceroNavigations { get; set; } = new List<EquEquipo>();

    public virtual ICollection<EquEquipo> EquEquipoIdTerceroServicioNavigations { get; set; } = new List<EquEquipo>();

    public virtual ICollection<EquTrazabilidad> EquTrazabilidads { get; set; } = new List<EquTrazabilidad>();

    public virtual ICollection<GenConfiguracionServicio> GenConfiguracionServicios { get; set; } = new List<GenConfiguracionServicio>();

    public virtual TerEstadoTercero IdEstadoTerceroNavigation { get; set; } = null!;

    public virtual DocFormaPago? IdFormaPagoNavigation { get; set; }

    public virtual TerNaturalezaTercero IdNaturalezaTerceroNavigation { get; set; } = null!;

    public virtual GenZona IdZonaNavigation { get; set; } = null!;

    public virtual ICollection<LicLicencium> LicLicencia { get; set; } = new List<LicLicencium>();

    public virtual ICollection<SegPerfilTercero> SegPerfilTerceros { get; set; } = new List<SegPerfilTercero>();

    public virtual ICollection<TerContacto> TerContactos { get; set; } = new List<TerContacto>();

    public virtual ICollection<TerSucursal> TerSucursals { get; set; } = new List<TerSucursal>();

    public virtual ICollection<TerTerceroListaprecio> TerTerceroListaprecios { get; set; } = new List<TerTerceroListaprecio>();

    public virtual ICollection<TerTerceroSector> TerTerceroSectors { get; set; } = new List<TerTerceroSector>();

    public virtual ICollection<TerTerceroUsuario> TerTerceroUsuarios { get; set; } = new List<TerTerceroUsuario>();
}
