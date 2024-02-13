using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewSegUsuarioCatalogoEquipoConfiguration : IEntityTypeConfiguration<ViewSegUsuarioCatalogoEquipo>
{
    public void Configure(EntityTypeBuilder<ViewSegUsuarioCatalogoEquipo> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_seg_usuario_catalogo_equipo");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.CatCatalogoEquipoBloquearCostear).HasColumnName("cat_catalogo_equipo_bloquearCostear");
        builder.Property(e => e.CatCatalogoEquipoCatalogoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_catalogo_codigo");
        builder.Property(e => e.CatCatalogoEquipoCatalogoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo.equipo_catalogo.equipo");
        builder.Property(e => e.CatCatalogoEquipoCodigoInventario)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_codigoInventario");
        builder.Property(e => e.CatCatalogoEquipoDescripcion)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("cat_catalogo_equipo_descripcion");
        builder.Property(e => e.CatCatalogoEquipoEsNacional).HasColumnName("cat_catalogo_equipo_esNacional");
        builder.Property(e => e.CatCatalogoEquipoGarantiaHoras).HasColumnName("cat_catalogo.equipo_garantiaHoras");
        builder.Property(e => e.CatCatalogoEquipoGarantiaMeses).HasColumnName("cat_catalogo.equipo_garantiaMeses");
        builder.Property(e => e.CatCatalogoEquipoIdFamilia).HasColumnName("cat_catalogo_equipo_id_familia");
        builder.Property(e => e.CatCatalogoEquipoIdImpuesto).HasColumnName("cat_catalogo_equipo_id_impuesto");
        builder.Property(e => e.CatCatalogoEquipoIdMarca).HasColumnName("cat_catalogo.equipo_id_marca");
        builder.Property(e => e.CatCatalogoEquipoIdSubtipoCatalogo).HasColumnName("cat_catalogo_equipo_id_subtipoCatalogo");
        builder.Property(e => e.CatCatalogoEquipoIdUnidad).HasColumnName("cat_catalogo_equipo_id_unidad");
        builder.Property(e => e.CatCatalogoEquipoManejaHorometro).HasColumnName("cat_catalogo.equipo_manejaHorometro");
        builder.Property(e => e.CatCatalogoEquipoPrecioVenta)
            .HasColumnType("money")
            .HasColumnName("cat_catalogo_equipo_precioVenta");
        builder.Property(e => e.CatCatalogoEquipoTiempoConsecucion).HasColumnName("cat_catalogo_equipo_tiempoConsecucion");
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
        builder.Property(e => e.GenTipoServicioDiasGarantia).HasColumnName("gen_tipoServicio_diasGarantia");
        builder.Property(e => e.GenTipoServicioTieneGarantia).HasColumnName("gen_tipoServicio_tieneGarantia");
        builder.Property(e => e.GenTipoServicioTipoServicio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_tipoServicio_tipoServicio");
        builder.Property(e => e.GenTipoServicioTipoServicioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_tipoServicio_tipoServicio_codigo");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdCatalogoEquipo).HasColumnName("id_catalogo.equipo");
        builder.Property(e => e.IdTipoServicio).HasColumnName("id_tipoServicio");
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
            .HasMaxLength(100)
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
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.UsuarioCatalogoEquipo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("usuario_catalogo.equipo");
    }
}
