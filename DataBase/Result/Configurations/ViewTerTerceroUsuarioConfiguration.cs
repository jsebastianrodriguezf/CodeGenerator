using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewTerTerceroUsuarioConfiguration : IEntityTypeConfiguration<ViewTerTerceroUsuario>
{
    public void Configure(EntityTypeBuilder<ViewTerTerceroUsuario> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_ter_tercero_usuario");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.SegUsuarioAccesoActivo).HasColumnName("seg_usuario_accesoActivo");
        builder.Property(e => e.SegUsuarioAplicaRecargo).HasColumnName("seg_usuario_aplicaRecargo");
        builder.Property(e => e.SegUsuarioCambiarClave).HasColumnName("seg_usuario_cambiarClave");
        builder.Property(e => e.SegUsuarioClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_clave");
        builder.Property(e => e.SegUsuarioCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_costoHora");
        builder.Property(e => e.SegUsuarioDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_direccion");
        builder.Property(e => e.SegUsuarioEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_email");
        builder.Property(e => e.SegUsuarioFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioHabilitado).HasColumnName("seg_usuario_habilitado");
        builder.Property(e => e.SegUsuarioIdCargo).HasColumnName("seg_usuario_id_cargo");
        builder.Property(e => e.SegUsuarioIdGrupo).HasColumnName("seg_usuario_id_grupo");
        builder.Property(e => e.SegUsuarioIdPerfil).HasColumnName("seg_usuario_id_perfil");
        builder.Property(e => e.SegUsuarioIdUsuario).HasColumnName("seg_usuario_id_usuario");
        builder.Property(e => e.SegUsuarioIdZona).HasColumnName("seg_usuario_id_zona");
        builder.Property(e => e.SegUsuarioIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_identificacion");
        builder.Property(e => e.SegUsuarioIntentosFallidos).HasColumnName("seg_usuario_intentosFallidos");
        builder.Property(e => e.SegUsuarioNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_nombre");
        builder.Property(e => e.SegUsuarioNumeroIngresos).HasColumnName("seg_usuario_numeroIngresos");
        builder.Property(e => e.SegUsuarioPorcentajeComision).HasColumnName("seg_usuario_porcentajeComision");
        builder.Property(e => e.SegUsuarioPreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_preferencias");
        builder.Property(e => e.SegUsuarioProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_profesion");
        builder.Property(e => e.SegUsuarioSexo).HasColumnName("seg_usuario_sexo");
        builder.Property(e => e.SegUsuarioTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_telefono");
        builder.Property(e => e.SegUsuarioUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_usuario");
        builder.Property(e => e.SegUsuarioUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_usuario_codigo");
        builder.Property(e => e.TerTerceroClasificacion)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_clasificacion");
        builder.Property(e => e.TerTerceroContacto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_contacto");
        builder.Property(e => e.TerTerceroDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_direccion");
        builder.Property(e => e.TerTerceroEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_email");
        builder.Property(e => e.TerTerceroEsCliente).HasColumnName("ter_tercero_esCliente");
        builder.Property(e => e.TerTerceroEsEmpresaPropia).HasColumnName("ter_tercero_esEmpresaPropia");
        builder.Property(e => e.TerTerceroEsFabricante).HasColumnName("ter_tercero_esFabricante");
        builder.Property(e => e.TerTerceroEsProspecto).HasColumnName("ter_tercero_esProspecto");
        builder.Property(e => e.TerTerceroEsProveedor).HasColumnName("ter_tercero_esProveedor");
        builder.Property(e => e.TerTerceroEsTransportador).HasColumnName("ter_tercero_esTransportador");
        builder.Property(e => e.TerTerceroFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_fax");
        builder.Property(e => e.TerTerceroIdEstadoTercero).HasColumnName("ter_tercero_id_estadoTercero");
        builder.Property(e => e.TerTerceroIdNaturalezaTercero).HasColumnName("ter_tercero_id_naturalezaTercero");
        builder.Property(e => e.TerTerceroIdZona).HasColumnName("ter_tercero_id_zona");
        builder.Property(e => e.TerTerceroNotas)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_notas");
        builder.Property(e => e.TerTerceroRepresentante)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_representante");
        builder.Property(e => e.TerTerceroTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_telefono");
        builder.Property(e => e.TerTerceroTercero)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero");
        builder.Property(e => e.TerTerceroTerceroCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero_codigo");
        builder.Property(e => e.TerTerceroTerceroNit)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero_nit");
        builder.Property(e => e.TerTerceroTerceroNombreCorto)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_tercero_nombreCorto");
        builder.Property(e => e.TerTerceroWebsite)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_website");
        builder.Property(e => e.TerceroUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tercero_usuario");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
