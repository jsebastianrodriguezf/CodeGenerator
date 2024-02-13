using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class SegUsuarioConfiguration : IEntityTypeConfiguration<SegUsuario>
{
    public void Configure(EntityTypeBuilder<SegUsuario> builder)
    {
        builder.ToTable("seg_usuario");

        builder.HasIndex(e => e.Eid, "IX_seg_usuario");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.AccesoActivo)
            .HasDefaultValue(false)
            .HasColumnName("accesoActivo");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.AplicaRecargo).HasColumnName("aplicaRecargo");
        builder.Property(e => e.CambiarClave)
            .HasDefaultValue(true)
            .HasColumnName("cambiarClave");
        builder.Property(e => e.Clave)
            .HasMaxLength(48)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("clave");
        builder.Property(e => e.CostoHora)
            .HasColumnType("money")
            .HasColumnName("costoHora");
        builder.Property(e => e.Direccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("direccion");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("email");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaIntentoFallidoFh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaIntentoFallido_fh");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaUltimoCambioClaveFh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaUltimoCambioClave_fh");
        builder.Property(e => e.FechaUltimoIngresoFh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaUltimoIngreso_fh");
        builder.Property(e => e.Habilitado)
            .HasDefaultValue(true)
            .HasColumnName("habilitado");
        builder.Property(e => e.IdCargo).HasColumnName("id_cargo");
        builder.Property(e => e.IdDispositivo)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("idDispositivo");
        builder.Property(e => e.IdGrupo).HasColumnName("id_grupo");
        builder.Property(e => e.IdPerfil).HasColumnName("id_perfil");
        builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.Identificacion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("identificacion");
        builder.Property(e => e.IntentosFallidos)
            .HasDefaultValue(0)
            .HasColumnName("intentosFallidos");
        builder.Property(e => e.Nombre)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("nombre");
        builder.Property(e => e.NumeroIngresos)
            .HasDefaultValue(0)
            .HasColumnName("numeroIngresos");
        builder.Property(e => e.PorcentajeComision).HasColumnName("porcentajeComision");
        builder.Property(e => e.Preferencias)
            .HasColumnType("image")
            .HasColumnName("preferencias");
        builder.Property(e => e.Profesion)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("profesion");
        builder.Property(e => e.Sexo).HasColumnName("sexo");
        builder.Property(e => e.Telefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("telefono");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Usuario)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("usuario");
        builder.Property(e => e.UsuarioCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("usuario_codigo");

        builder.HasOne(d => d.IdCargoNavigation).WithMany(p => p.SegUsuarios)
            .HasForeignKey(d => d.IdCargo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_usuario_id_cargo");

        builder.HasOne(d => d.IdGrupoNavigation).WithMany(p => p.SegUsuarios)
            .HasForeignKey(d => d.IdGrupo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_usuario_id_grupo");

        builder.HasOne(d => d.IdPerfilNavigation).WithMany(p => p.SegUsuarios)
            .HasForeignKey(d => d.IdPerfil)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_usuario_id_perfil");

        builder.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.InverseIdUsuarioNavigation)
            .HasForeignKey(d => d.IdUsuario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_usuario_id_usuario");

        builder.HasOne(d => d.IdZonaNavigation).WithMany(p => p.SegUsuarios)
            .HasForeignKey(d => d.IdZona)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_seg_usuario_id_zona");
    }
}
