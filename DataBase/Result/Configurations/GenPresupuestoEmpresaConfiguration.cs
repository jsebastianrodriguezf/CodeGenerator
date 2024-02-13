using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class GenPresupuestoEmpresaConfiguration : IEntityTypeConfiguration<GenPresupuestoEmpresa>
{
    public void Configure(EntityTypeBuilder<GenPresupuestoEmpresa> builder)
    {
        builder.ToTable("gen_presupuestoEmpresa");

        builder.HasIndex(e => e.Eid, "IX_gen_presupuestoEmpresa");

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
        builder.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PresupuestoEmpresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("presupuestoEmpresa");
        builder.Property(e => e.PresupuestoEmpresaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("presupuestoEmpresa_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Valor).HasColumnType("money");

        builder.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.GenPresupuestoEmpresas)
            .HasForeignKey(d => d.IdEmpresa)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_gen_presupuestoEmpresa_id_empresa");
    }
}
