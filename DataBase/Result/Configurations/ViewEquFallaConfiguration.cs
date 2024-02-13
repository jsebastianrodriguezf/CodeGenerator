using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewEquFallaConfiguration : IEntityTypeConfiguration<ViewEquFalla>
{
    public void Configure(EntityTypeBuilder<ViewEquFalla> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_equ_falla");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquFallaPadreFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_falla_padre_falla");
        builder.Property(e => e.EquFallaPadreFallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_falla_padre_falla_codigo");
        builder.Property(e => e.EquFallaPadreIdFalla).HasColumnName("equ_falla_padre_id_falla");
        builder.Property(e => e.EquFallaPadreIdTipoFalla).HasColumnName("equ_falla_padre_id_tipoFalla");
        builder.Property(e => e.EquFallaPadreProcedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("equ_falla_padre_procedimiento");
        builder.Property(e => e.EquTipoFallaTipoFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_tipoFalla_tipoFalla");
        builder.Property(e => e.EquTipoFallaTipoFallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_tipoFalla_tipoFalla_codigo");
        builder.Property(e => e.Falla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("falla");
        builder.Property(e => e.FallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("falla_codigo");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdFalla).HasColumnName("id_falla");
        builder.Property(e => e.IdTipoFalla).HasColumnName("id_tipoFalla");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Procedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("procedimiento");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
