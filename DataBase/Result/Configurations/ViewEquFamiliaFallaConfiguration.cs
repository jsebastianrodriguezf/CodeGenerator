using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewEquFamiliaFallaConfiguration : IEntityTypeConfiguration<ViewEquFamiliaFalla>
{
    public void Configure(EntityTypeBuilder<ViewEquFamiliaFalla> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_equ_familia_falla");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquFallaFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_falla_falla");
        builder.Property(e => e.EquFallaFallaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_falla_falla_codigo");
        builder.Property(e => e.EquFallaIdFalla).HasColumnName("equ_falla_id_falla");
        builder.Property(e => e.EquFallaIdTipoFalla).HasColumnName("equ_falla_id_tipoFalla");
        builder.Property(e => e.EquFallaProcedimiento)
            .HasMaxLength(8000)
            .IsUnicode(false)
            .HasColumnName("equ_falla_procedimiento");
        builder.Property(e => e.FamiliaFalla)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("familia_falla");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenFamiliaFamilia)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_familia_familia");
        builder.Property(e => e.GenFamiliaFamiliaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_familia_familia_codigo");
        builder.Property(e => e.GenFamiliaIdFamilia).HasColumnName("gen_familia_id_familia");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdFalla).HasColumnName("id_falla");
        builder.Property(e => e.IdFamilia).HasColumnName("id_familia");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
