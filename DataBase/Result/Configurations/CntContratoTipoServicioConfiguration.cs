using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CntContratoTipoServicioConfiguration : IEntityTypeConfiguration<CntContratoTipoServicio>
{
    public void Configure(EntityTypeBuilder<CntContratoTipoServicio> builder)
    {
        builder.ToTable("cnt_contrato_tipoServicio");

        builder.HasIndex(e => e.Eid, "IX_cnt_contrato_tipoServicio");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.ContratoTipoServicio)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("contrato_tipoServicio");
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
        builder.Property(e => e.IdListaPrecio).HasColumnName("id_listaPrecio");
        builder.Property(e => e.IdTipoServicio).HasColumnName("id_tipoServicio");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdContratoNavigation).WithMany(p => p.CntContratoTipoServicios)
            .HasForeignKey(d => d.IdContrato)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_tipoServicio_id_contrato");

        builder.HasOne(d => d.IdListaPrecioNavigation).WithMany(p => p.CntContratoTipoServicios)
            .HasForeignKey(d => d.IdListaPrecio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_tipoServicio_id_listaPrecio");

        builder.HasOne(d => d.IdTipoServicioNavigation).WithMany(p => p.CntContratoTipoServicios)
            .HasForeignKey(d => d.IdTipoServicio)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_contrato_tipoServicio_id_tipoServicio");
    }
}
