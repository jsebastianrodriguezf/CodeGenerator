using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CntCorrimientoVisitaFijaConfiguration : IEntityTypeConfiguration<CntCorrimientoVisitaFija>
{
    public void Configure(EntityTypeBuilder<CntCorrimientoVisitaFija> builder)
    {
        builder.ToTable("cnt_corrimientoVisitaFija");

        builder.HasIndex(e => e.Eid, "IX_cnt_corrimientoVisitaFija");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.CorrimientoVisitaFija)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("corrimientoVisitaFija");
        builder.Property(e => e.CorrimientoVisitaFijaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("corrimientoVisitaFija_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FechaOriginalFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaOriginal_ff");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdVisitaFija).HasColumnName("id_visitaFija");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdVisitaFijaNavigation).WithMany(p => p.CntCorrimientoVisitaFijas)
            .HasForeignKey(d => d.IdVisitaFija)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_corrimientoVisitaFija_id_visitaFija");
    }
}
