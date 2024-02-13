using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class LicLicenciaParametroConfiguration : IEntityTypeConfiguration<LicLicenciaParametro>
{
    public void Configure(EntityTypeBuilder<LicLicenciaParametro> builder)
    {
        builder.ToTable("lic_licencia_parametro");

        builder.HasIndex(e => e.Eid, "IX_lic_licencia_parametro");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsParteSerial).HasColumnName("esParteSerial");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdLicencia).HasColumnName("id_licencia");
        builder.Property(e => e.IdParametro).HasColumnName("id_parametro");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.LicenciaParametro)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("licencia_parametro");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Valor)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("valor");

        builder.HasOne(d => d.IdLicenciaNavigation).WithMany(p => p.LicLicenciaParametros)
            .HasForeignKey(d => d.IdLicencia)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_lic_licencia_parametro_id_licencia");

        builder.HasOne(d => d.IdParametroNavigation).WithMany(p => p.LicLicenciaParametros)
            .HasForeignKey(d => d.IdParametro)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_lic_licencia_parametro_id_parametro");
    }
}
