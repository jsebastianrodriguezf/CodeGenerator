using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DisObraConfiguration : IEntityTypeConfiguration<DisObra>
{
    public void Configure(EntityTypeBuilder<DisObra> builder)
    {
        builder.ToTable("dis_obra");

        builder.HasIndex(e => e.Eid, "IX_dis_obra");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFinalFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFinal_ff");
        builder.Property(e => e.FechaInicialFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicial_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Obra)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("obra");
        builder.Property(e => e.ObraCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("obra_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.DisObras)
            .HasForeignKey(d => d.IdSucursal)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_dis_obra_id_sucursal");
    }
}
