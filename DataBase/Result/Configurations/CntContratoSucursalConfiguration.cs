using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CntContratoSucursalConfiguration : IEntityTypeConfiguration<CntContratoSucursal>
{
    public void Configure(EntityTypeBuilder<CntContratoSucursal> builder)
    {
        builder.ToTable("cnt_contrato_sucursal");

        builder.HasIndex(e => e.Eid, "IX_cnt_contrato_sucursal");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.ContratoSucursal)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("contrato_sucursal");
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
        builder.Property(e => e.IdContrato).HasColumnName("id_contrato");
        builder.Property(e => e.IdSucursal).HasColumnName("id_sucursal");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PrecioServicio)
            .HasColumnType("money")
            .HasColumnName("precioServicio");
        builder.Property(e => e.PrecioVisita)
            .HasColumnType("money")
            .HasColumnName("precioVisita");
        builder.Property(e => e.Presupuesto)
            .HasColumnType("money")
            .HasColumnName("presupuesto");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdContratoNavigation).WithMany(p => p.CntContratoSucursals)
            .HasForeignKey(d => d.IdContrato)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_sucursal_id_contrato");

        builder.HasOne(d => d.IdSucursalNavigation).WithMany(p => p.CntContratoSucursals)
            .HasForeignKey(d => d.IdSucursal)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_sucursal_id_sucursal");
    }
}
