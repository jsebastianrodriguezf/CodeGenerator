using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class LicLicenciumConfiguration : IEntityTypeConfiguration<LicLicencium>
{
    public void Configure(EntityTypeBuilder<LicLicencium> builder)
    {
        builder.ToTable("lic_licencia");

        builder.HasIndex(e => e.Eid, "IX_lic_licencia");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Clave)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("clave");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFinFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFin_ff");
        builder.Property(e => e.FechaInicioFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicio_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdCatalogo).HasColumnName("id_catalogo");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Licencia)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("licencia");
        builder.Property(e => e.LicenciaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("licencia_codigo");
        builder.Property(e => e.Serial)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("serial");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoNavigation).WithMany(p => p.LicLicencia)
            .HasForeignKey(d => d.IdCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_lic_licencia_id_catalogo");

        builder.HasOne(d => d.IdTerceroNavigation).WithMany(p => p.LicLicencia)
            .HasForeignKey(d => d.IdTercero)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_lic_licencia_id_tercero");
    }
}
