using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CntTipoContratoConfiguration : IEntityTypeConfiguration<CntTipoContrato>
{
    public void Configure(EntityTypeBuilder<CntTipoContrato> builder)
    {
        builder.ToTable("cnt_tipoContrato");

        builder.HasIndex(e => e.Eid, "IX_cnt_tipoContrato");

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
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.TipoContrato)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("tipoContrato");
        builder.Property(e => e.TipoContratoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("tipoContrato_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
