using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGasGastoConfiguration : IEntityTypeConfiguration<ViewGasGasto>
{
    public void Configure(EntityTypeBuilder<ViewGasGasto> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gas_gasto");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Concepto)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("concepto");
        builder.Property(e => e.Consignado).HasColumnName("consignado");
        builder.Property(e => e.Dias).HasColumnName("dias");
        builder.Property(e => e.DocEstadoTipoDocumentoAfectaIndicador).HasColumnName("doc_estadoTipoDocumento_afectaIndicador");
        builder.Property(e => e.DocEstadoTipoDocumentoAfectaInventario).HasColumnName("doc_estadoTipoDocumento_afectaInventario");
        builder.Property(e => e.DocEstadoTipoDocumentoColor)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_color");
        builder.Property(e => e.DocEstadoTipoDocumentoDescripcion)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_descripcion");
        builder.Property(e => e.DocEstadoTipoDocumentoEditaDocumento).HasColumnName("doc_estadoTipoDocumento_editaDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoEstadoTipoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_estadoTipoDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoEstadoTipoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_estadoTipoDocumento_estadoTipoDocumento_codigo");
        builder.Property(e => e.DocEstadoTipoDocumentoIdTipoDocumento).HasColumnName("doc_estadoTipoDocumento_id_tipoDocumento");
        builder.Property(e => e.DocEstadoTipoDocumentoOrden).HasColumnName("doc_estadoTipoDocumento_orden");
        builder.Property(e => e.DocEstadoTipoDocumentoPuedeRegresar).HasColumnName("doc_estadoTipoDocumento_puedeRegresar");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GasTipoGastoTipoGasto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gas_tipoGasto_tipoGasto");
        builder.Property(e => e.GasTipoGastoTipoGastoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gas_tipoGasto_tipoGasto_codigo");
        builder.Property(e => e.Gasto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gasto");
        builder.Property(e => e.GastoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gasto_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdEstadoTipoDocumento).HasColumnName("id_estadoTipoDocumento");
        builder.Property(e => e.IdTipoGasto).HasColumnName("id_tipoGasto");
        builder.Property(e => e.IdUsuarioAprobo).HasColumnName("id_usuario_aprobo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdUsuarioSolicitante).HasColumnName("id_usuario_solicitante");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Numero).HasColumnName("numero");
        builder.Property(e => e.SegUsuarioAproboAccesoActivo).HasColumnName("seg_usuario_aprobo_accesoActivo");
        builder.Property(e => e.SegUsuarioAproboAplicaRecargo).HasColumnName("seg_usuario_aprobo_aplicaRecargo");
        builder.Property(e => e.SegUsuarioAproboCambiarClave).HasColumnName("seg_usuario_aprobo_cambiarClave");
        builder.Property(e => e.SegUsuarioAproboClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_aprobo_clave");
        builder.Property(e => e.SegUsuarioAproboCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_aprobo_costoHora");
        builder.Property(e => e.SegUsuarioAproboDireccion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_aprobo_direccion");
        builder.Property(e => e.SegUsuarioAproboEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_aprobo_email");
        builder.Property(e => e.SegUsuarioAproboFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_aprobo_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioAproboFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_aprobo_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioAproboFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_aprobo_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioAproboIdCargo).HasColumnName("seg_usuario_aprobo_id_cargo");
        builder.Property(e => e.SegUsuarioAproboIdGrupo).HasColumnName("seg_usuario_aprobo_id_grupo");
        builder.Property(e => e.SegUsuarioAproboIdPerfil).HasColumnName("seg_usuario_aprobo_id_perfil");
        builder.Property(e => e.SegUsuarioAproboIdUsuario).HasColumnName("seg_usuario_aprobo_id_usuario");
        builder.Property(e => e.SegUsuarioAproboIdZona).HasColumnName("seg_usuario_aprobo_id_zona");
        builder.Property(e => e.SegUsuarioAproboIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_aprobo_identificacion");
        builder.Property(e => e.SegUsuarioAproboIntentosFallidos).HasColumnName("seg_usuario_aprobo_intentosFallidos");
        builder.Property(e => e.SegUsuarioAproboNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_aprobo_nombre");
        builder.Property(e => e.SegUsuarioAproboNumeroIngresos).HasColumnName("seg_usuario_aprobo_numeroIngresos");
        builder.Property(e => e.SegUsuarioAproboPorcentajeComision).HasColumnName("seg_usuario_aprobo_porcentajeComision");
        builder.Property(e => e.SegUsuarioAproboPreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_aprobo_preferencias");
        builder.Property(e => e.SegUsuarioAproboProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_aprobo_profesion");
        builder.Property(e => e.SegUsuarioAproboSexo).HasColumnName("seg_usuario_aprobo_sexo");
        builder.Property(e => e.SegUsuarioAproboTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_aprobo_telefono");
        builder.Property(e => e.SegUsuarioAproboUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_aprobo_usuario");
        builder.Property(e => e.SegUsuarioAproboUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_aprobo_usuario_codigo");
        builder.Property(e => e.SegUsuarioSolicitanteAccesoActivo).HasColumnName("seg_usuario_solicitante_accesoActivo");
        builder.Property(e => e.SegUsuarioSolicitanteAplicaRecargo).HasColumnName("seg_usuario_solicitante_aplicaRecargo");
        builder.Property(e => e.SegUsuarioSolicitanteCambiarClave).HasColumnName("seg_usuario_solicitante_cambiarClave");
        builder.Property(e => e.SegUsuarioSolicitanteClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_clave");
        builder.Property(e => e.SegUsuarioSolicitanteCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_solicitante_costoHora");
        builder.Property(e => e.SegUsuarioSolicitanteDireccion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_direccion");
        builder.Property(e => e.SegUsuarioSolicitanteEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_email");
        builder.Property(e => e.SegUsuarioSolicitanteFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_solicitante_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioSolicitanteFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_solicitante_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioSolicitanteFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_solicitante_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioSolicitanteIdCargo).HasColumnName("seg_usuario_solicitante_id_cargo");
        builder.Property(e => e.SegUsuarioSolicitanteIdGrupo).HasColumnName("seg_usuario_solicitante_id_grupo");
        builder.Property(e => e.SegUsuarioSolicitanteIdPerfil).HasColumnName("seg_usuario_solicitante_id_perfil");
        builder.Property(e => e.SegUsuarioSolicitanteIdUsuario).HasColumnName("seg_usuario_solicitante_id_usuario");
        builder.Property(e => e.SegUsuarioSolicitanteIdZona).HasColumnName("seg_usuario_solicitante_id_zona");
        builder.Property(e => e.SegUsuarioSolicitanteIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_identificacion");
        builder.Property(e => e.SegUsuarioSolicitanteIntentosFallidos).HasColumnName("seg_usuario_solicitante_intentosFallidos");
        builder.Property(e => e.SegUsuarioSolicitanteNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_nombre");
        builder.Property(e => e.SegUsuarioSolicitanteNumeroIngresos).HasColumnName("seg_usuario_solicitante_numeroIngresos");
        builder.Property(e => e.SegUsuarioSolicitantePorcentajeComision).HasColumnName("seg_usuario_solicitante_porcentajeComision");
        builder.Property(e => e.SegUsuarioSolicitantePreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_solicitante_preferencias");
        builder.Property(e => e.SegUsuarioSolicitanteProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_profesion");
        builder.Property(e => e.SegUsuarioSolicitanteSexo).HasColumnName("seg_usuario_solicitante_sexo");
        builder.Property(e => e.SegUsuarioSolicitanteTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_telefono");
        builder.Property(e => e.SegUsuarioSolicitanteUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_usuario");
        builder.Property(e => e.SegUsuarioSolicitanteUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_solicitante_usuario_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Valor).HasColumnName("valor");
    }
}
