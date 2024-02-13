using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocDocumentoComentarioConfiguration : IEntityTypeConfiguration<ViewDocDocumentoComentario>
{
    public void Configure(EntityTypeBuilder<ViewDocDocumentoComentario> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_documentoComentario");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Cerrada).HasColumnName("cerrada");
        builder.Property(e => e.Comentario)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("comentario");
        builder.Property(e => e.ConRespuesta).HasColumnName("conRespuesta");
        builder.Property(e => e.DocDocumentoComentarioPadreCerrada).HasColumnName("doc_documentoComentario_padre_cerrada");
        builder.Property(e => e.DocDocumentoComentarioPadreComentario)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("doc_documentoComentario_padre_comentario");
        builder.Property(e => e.DocDocumentoComentarioPadreConRespuesta).HasColumnName("doc_documentoComentario_padre_conRespuesta");
        builder.Property(e => e.DocDocumentoComentarioPadreDocumentoComentario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documentoComentario_padre_documentoComentario");
        builder.Property(e => e.DocDocumentoComentarioPadreDocumentoComentarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documentoComentario_padre_documentoComentario_codigo");
        builder.Property(e => e.DocDocumentoComentarioPadreFechaOrden)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documentoComentario_padre_fechaOrden");
        builder.Property(e => e.DocDocumentoComentarioPadreFechaOriginal)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documentoComentario_padre_fechaOriginal");
        builder.Property(e => e.DocDocumentoComentarioPadreFechaRecordarFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documentoComentario_padre_fechaRecordar_fh");
        builder.Property(e => e.DocDocumentoComentarioPadreFinalizado).HasColumnName("doc_documentoComentario_padre_finalizado");
        builder.Property(e => e.DocDocumentoComentarioPadreIdContacto).HasColumnName("doc_documentoComentario_padre_id_contacto");
        builder.Property(e => e.DocDocumentoComentarioPadreIdDocumento).HasColumnName("doc_documentoComentario_padre_id_documento");
        builder.Property(e => e.DocDocumentoComentarioPadreIdDocumentoComentario).HasColumnName("doc_documentoComentario_padre_id_documentoComentario");
        builder.Property(e => e.DocDocumentoComentarioPadreIdReporteTecnico).HasColumnName("doc_documentoComentario_padre_id_reporteTecnico");
        builder.Property(e => e.DocDocumentoComentarioPadreIdTarea).HasColumnName("doc_documentoComentario_padre_id_tarea");
        builder.Property(e => e.DocDocumentoComentarioPadreIdUsuario).HasColumnName("doc_documentoComentario_padre_id_usuario");
        builder.Property(e => e.DocDocumentoComentarioPadreIdUsuarioOriginal).HasColumnName("doc_documentoComentario_padre_id_usuarioOriginal");
        builder.Property(e => e.DocDocumentoComentarioPadreRecordar).HasColumnName("doc_documentoComentario_padre_recordar");
        builder.Property(e => e.DocDocumentoComentarioPadreRelevante).HasColumnName("doc_documentoComentario_padre_relevante");
        builder.Property(e => e.DocDocumentoCosto).HasColumnName("doc_documento_costo");
        builder.Property(e => e.DocDocumentoCostoPlaneado).HasColumnName("doc_documento_costoPlaneado");
        builder.Property(e => e.DocDocumentoDescuento).HasColumnName("doc_documento_descuento");
        builder.Property(e => e.DocDocumentoDescuentoPlaneado).HasColumnName("doc_documento_descuentoPlaneado");
        builder.Property(e => e.DocDocumentoDocumento)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_documento_documento");
        builder.Property(e => e.DocDocumentoDocumentoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_documento_documento_codigo");
        builder.Property(e => e.DocDocumentoDocumentoNumero).HasColumnName("doc_documento_documento_numero");
        builder.Property(e => e.DocDocumentoFechaCierreFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fechaCierre_ff");
        builder.Property(e => e.DocDocumentoFechaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fecha_fh");
        builder.Property(e => e.DocDocumentoFechaLimiteFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fechaLimite_fh");
        builder.Property(e => e.DocDocumentoFechaSugeridaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_documento_fechaSugerida_fh");
        builder.Property(e => e.DocDocumentoIdDocumento).HasColumnName("doc_documento_id_documento");
        builder.Property(e => e.DocDocumentoIdEstadoTipoDocumento).HasColumnName("doc_documento_id_estadoTipoDocumento");
        builder.Property(e => e.DocDocumentoIdMoneda).HasColumnName("doc_documento_id_moneda");
        builder.Property(e => e.DocDocumentoIdMotivoestado).HasColumnName("doc_documento_id_motivoestado");
        builder.Property(e => e.DocDocumentoIdPrioridadDocumento).HasColumnName("doc_documento_id_prioridadDocumento");
        builder.Property(e => e.DocDocumentoIdSubtipoDocumento).HasColumnName("doc_documento_id_subtipoDocumento");
        builder.Property(e => e.DocDocumentoIdTerceroCliente).HasColumnName("doc_documento_id_tercero_cliente");
        builder.Property(e => e.DocDocumentoIdTerceroProveedor).HasColumnName("doc_documento_id_tercero_proveedor");
        builder.Property(e => e.DocDocumentoIdUsuarioAsignado).HasColumnName("doc_documento_id_usuario_asignado");
        builder.Property(e => e.DocDocumentoIdUsuarioEnUso).HasColumnName("doc_documento_id_usuario_enUso");
        builder.Property(e => e.DocDocumentoIva).HasColumnName("doc_documento_iva");
        builder.Property(e => e.DocDocumentoIvaPlaneado).HasColumnName("doc_documento_ivaPlaneado");
        builder.Property(e => e.DocDocumentoPrefijo)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasColumnName("doc_documento_prefijo");
        builder.Property(e => e.DocDocumentoRentabilidad).HasColumnName("doc_documento_rentabilidad");
        builder.Property(e => e.DocDocumentoSubtotal).HasColumnName("doc_documento_subtotal");
        builder.Property(e => e.DocDocumentoSubtotalPlaneado).HasColumnName("doc_documento_subtotalPlaneado");
        builder.Property(e => e.DocDocumentoTotal).HasColumnName("doc_documento_total");
        builder.Property(e => e.DocDocumentoTotalPlaneado).HasColumnName("doc_documento_totalPlaneado");
        builder.Property(e => e.DocDocumentoTrm).HasColumnName("doc_documento_trm");
        builder.Property(e => e.DocTareaFechaPlaneadaFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("doc_tarea_fechaPlaneada_fh");
        builder.Property(e => e.DocTareaIdCargo).HasColumnName("doc_tarea_id_cargo");
        builder.Property(e => e.DocTareaIdCatalogo).HasColumnName("doc_tarea_id_catalogo");
        builder.Property(e => e.DocTareaIdDocumento).HasColumnName("doc_tarea_id_documento");
        builder.Property(e => e.DocTareaPorcentajeAvance).HasColumnName("doc_tarea_porcentajeAvance");
        builder.Property(e => e.DocTareaTarea)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("doc_tarea_tarea");
        builder.Property(e => e.DocTareaTareaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("doc_tarea_tarea_codigo");
        builder.Property(e => e.DocumentoComentario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("documentoComentario");
        builder.Property(e => e.DocumentoComentarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("documentoComentario_codigo");
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
        builder.Property(e => e.FechaOrden)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaOrden");
        builder.Property(e => e.FechaOriginal)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaOriginal");
        builder.Property(e => e.FechaRecordarFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaRecordar_fh");
        builder.Property(e => e.Finalizado).HasColumnName("finalizado");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdContacto).HasColumnName("id_contacto");
        builder.Property(e => e.IdDocumento).HasColumnName("id_documento");
        builder.Property(e => e.IdDocumentoComentario).HasColumnName("id_documentoComentario");
        builder.Property(e => e.IdReporteTecnico).HasColumnName("id_reporteTecnico");
        builder.Property(e => e.IdTarea).HasColumnName("id_tarea");
        builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdUsuarioOriginal).HasColumnName("id_usuarioOriginal");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.OrtReporteTecnicoCompromisos)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_compromisos");
        builder.Property(e => e.OrtReporteTecnicoIdGasto).HasColumnName("ort_reporteTecnico_id_gasto");
        builder.Property(e => e.OrtReporteTecnicoNumero)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_numero");
        builder.Property(e => e.OrtReporteTecnicoRecomendaciones)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_recomendaciones");
        builder.Property(e => e.OrtReporteTecnicoReporteTecnico)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_reporteTecnico");
        builder.Property(e => e.OrtReporteTecnicoReporteTecnicoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_reporteTecnico_codigo");
        builder.Property(e => e.OrtReporteTecnicoTrabajos)
            .HasMaxLength(4000)
            .IsUnicode(false)
            .HasColumnName("ort_reporteTecnico_trabajos");
        builder.Property(e => e.Recordar).HasColumnName("recordar");
        builder.Property(e => e.Relevante).HasColumnName("relevante");
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
        builder.Property(e => e.SegUsuarioCreoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_creo_nombre");
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
        builder.Property(e => e.TerContactoAccesoActivo).HasColumnName("ter_contacto_accesoActivo");
        builder.Property(e => e.TerContactoCargo)
            .HasMaxLength(100)
            .HasColumnName("ter_contacto_cargo");
        builder.Property(e => e.TerContactoCodigoAcceso)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_codigoAcceso");
        builder.Property(e => e.TerContactoContacto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_contacto");
        builder.Property(e => e.TerContactoContactoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_contacto_codigo");
        builder.Property(e => e.TerContactoDireccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_Direccion");
        builder.Property(e => e.TerContactoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_Email");
        builder.Property(e => e.TerContactoFax)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_Fax");
        builder.Property(e => e.TerContactoIdCargoContacto).HasColumnName("ter_contacto_id_cargoContacto");
        builder.Property(e => e.TerContactoIdTercero).HasColumnName("ter_contacto_id_tercero");
        builder.Property(e => e.TerContactoIdUsuario).HasColumnName("ter_contacto_id_usuario");
        builder.Property(e => e.TerContactoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_telefono");
        builder.Property(e => e.TerContactoTelefonoMovil)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("ter_contacto_telefonoMovil");
        builder.Property(e => e.TerTerceroCliente)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("ter_tercero_cliente");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
