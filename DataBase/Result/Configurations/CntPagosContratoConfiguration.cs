using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CntPagosContratoConfiguration : IEntityTypeConfiguration<CntPagosContrato>
{
    public void Configure(EntityTypeBuilder<CntPagosContrato> builder)
    {
        builder.ToTable("cnt_pagosContrato");

        builder.HasIndex(e => e.Eid, "IX_cnt_pagosContrato");

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
        builder.Property(e => e.FechaFf)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdContrato).HasColumnName("id_contrato");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.PagosContrato)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("pagosContrato");
        builder.Property(e => e.PagosContratoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("pagosContrato_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.Valor)
            .HasColumnType("money")
            .HasColumnName("valor");

        builder.HasOne(d => d.IdContratoNavigation).WithMany(p => p.CntPagosContratos)
            .HasForeignKey(d => d.IdContrato)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_cnt_pagosContrato_id_contrato");
    }
}
