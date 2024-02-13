using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewEquPrestamoConfiguration : IEntityTypeConfiguration<ViewEquPrestamo>
{
    public void Configure(EntityTypeBuilder<ViewEquPrestamo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_equ_prestamo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquEstadoPrestamoEstadoPrestamo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_estadoPrestamo_estadoPrestamo");
        builder.Property(e => e.EquEstadoPrestamoEstadoPrestamoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_estadoPrestamo_estadoPrestamo_codigo");
        builder.Property(e => e.FechaCompromisoFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCompromiso_ff");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaPrestamoFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaPrestamo_ff");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdEstadoPrestamo).HasColumnName("id_estadoPrestamo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioEntrego).HasColumnName("id_usuario_entrego");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Notas)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("notas");
        builder.Property(e => e.Prestamo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("prestamo");
        builder.Property(e => e.PrestamoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("prestamo_codigo");
        builder.Property(e => e.SegUsuarioEntregoAccesoActivo).HasColumnName("seg_usuario_entrego_accesoActivo");
        builder.Property(e => e.SegUsuarioEntregoAplicaRecargo).HasColumnName("seg_usuario_entrego_aplicaRecargo");
        builder.Property(e => e.SegUsuarioEntregoCambiarClave).HasColumnName("seg_usuario_entrego_cambiarClave");
        builder.Property(e => e.SegUsuarioEntregoClave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_entrego_clave");
        builder.Property(e => e.SegUsuarioEntregoCostoHora)
            .HasColumnType("money")
            .HasColumnName("seg_usuario_entrego_costoHora");
        builder.Property(e => e.SegUsuarioEntregoDireccion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_entrego_direccion");
        builder.Property(e => e.SegUsuarioEntregoEmail)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_entrego_email");
        builder.Property(e => e.SegUsuarioEntregoFechaIntentoFallidoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_entrego_fechaIntentoFallido_fh");
        builder.Property(e => e.SegUsuarioEntregoFechaUltimoCambioClaveFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_entrego_fechaUltimoCambioClave_fh");
        builder.Property(e => e.SegUsuarioEntregoFechaUltimoIngresoFh)
            .HasColumnType("smalldatetime")
            .HasColumnName("seg_usuario_entrego_fechaUltimoIngreso_fh");
        builder.Property(e => e.SegUsuarioEntregoIdCargo).HasColumnName("seg_usuario_entrego_id_cargo");
        builder.Property(e => e.SegUsuarioEntregoIdGrupo).HasColumnName("seg_usuario_entrego_id_grupo");
        builder.Property(e => e.SegUsuarioEntregoIdPerfil).HasColumnName("seg_usuario_entrego_id_perfil");
        builder.Property(e => e.SegUsuarioEntregoIdUsuario).HasColumnName("seg_usuario_entrego_id_usuario");
        builder.Property(e => e.SegUsuarioEntregoIdZona).HasColumnName("seg_usuario_entrego_id_zona");
        builder.Property(e => e.SegUsuarioEntregoIdentificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_entrego_identificacion");
        builder.Property(e => e.SegUsuarioEntregoIntentosFallidos).HasColumnName("seg_usuario_entrego_intentosFallidos");
        builder.Property(e => e.SegUsuarioEntregoNombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_entrego_nombre");
        builder.Property(e => e.SegUsuarioEntregoNumeroIngresos).HasColumnName("seg_usuario_entrego_numeroIngresos");
        builder.Property(e => e.SegUsuarioEntregoPorcentajeComision).HasColumnName("seg_usuario_entrego_porcentajeComision");
        builder.Property(e => e.SegUsuarioEntregoPreferencias)
            .HasColumnType("image")
            .HasColumnName("seg_usuario_entrego_preferencias");
        builder.Property(e => e.SegUsuarioEntregoProfesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_entrego_profesion");
        builder.Property(e => e.SegUsuarioEntregoSexo).HasColumnName("seg_usuario_entrego_sexo");
        builder.Property(e => e.SegUsuarioEntregoTelefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_entrego_telefono");
        builder.Property(e => e.SegUsuarioEntregoUsuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_entrego_usuario");
        builder.Property(e => e.SegUsuarioEntregoUsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("seg_usuario_entrego_usuario_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
