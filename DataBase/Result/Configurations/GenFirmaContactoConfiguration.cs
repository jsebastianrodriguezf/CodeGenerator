using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenFirmaContactoConfiguration : IEntityTypeConfiguration<GenFirmaContacto>
{
    public void Configure(EntityTypeBuilder<GenFirmaContacto> builder)
    {
        builder.ToTable("gen_firmaContacto");

        builder.HasIndex(e => e.Eid, "IX_gen_firmaContacto");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Archivobinario)
            .HasColumnType("image")
            .HasColumnName("archivobinario");
        builder.Property(e => e.Codigoacceso)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("codigoacceso");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_fh");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FirmaContacto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("firmaContacto");
        builder.Property(e => e.FirmaContactoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("firmaContacto_codigo");
        builder.Property(e => e.IdContacto).HasColumnName("id_contacto");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
