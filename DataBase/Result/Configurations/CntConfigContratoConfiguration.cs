using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class CntConfigContratoConfiguration : IEntityTypeConfiguration<CntConfigContrato>
{
    public void Configure(EntityTypeBuilder<CntConfigContrato> builder)
    {
        builder.HasKey(e => e.Id).HasName("PK_cnt_contratoEquipo_catalogo_tempario");

        builder.ToTable("cnt_configContrato");

        builder.HasIndex(e => e.Eid, "IX_cnt_contratoEquipo_catalogo_tempario");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.AproximarA)
            .HasDefaultValue(0)
            .HasColumnName("aproximarA");
        builder.Property(e => e.CadaN)
            .HasDefaultValue(0.0)
            .HasColumnName("cadaN");
        builder.Property(e => e.ConfigContrato)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("configContrato");
        builder.Property(e => e.Dia)
            .HasDefaultValue(0)
            .HasColumnName("dia");
        builder.Property(e => e.DiaHabil)
            .HasDefaultValue(0)
            .HasColumnName("diaHabil");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Estrategia)
            .HasDefaultValue(0)
            .HasColumnName("estrategia");
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFf)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fecha_ff");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Frecuencia)
            .HasDefaultValue(0)
            .HasColumnName("frecuencia");
        builder.Property(e => e.IdCatalogoTempario)
            .HasDefaultValue(0)
            .HasColumnName("id_catalogo.tempario");
        builder.Property(e => e.IdContratoEquipo)
            .HasDefaultValue(0)
            .HasColumnName("id_contratoEquipo");
        builder.Property(e => e.IdTerceroProveedor)
            .HasDefaultValue(0)
            .HasColumnName("id_tercero_proveedor");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IncluirMenores)
            .HasDefaultValue(false)
            .HasColumnName("incluirMenores");
        builder.Property(e => e.PorTrabajo)
            .HasDefaultValue(false)
            .HasColumnName("porTrabajo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCatalogoTemparioNavigation).WithMany(p => p.CntConfigContratos)
            .HasForeignKey(d => d.IdCatalogoTempario)
            .HasConstraintName("FK__cnt_contr__id_ca__0E322850");

        builder.HasOne(d => d.IdContratoEquipoNavigation).WithMany(p => p.CntConfigContratos)
            .HasForeignKey(d => d.IdContratoEquipo)
            .HasConstraintName("FK__cnt_contr__id_co__0C49DFDE");

        builder.HasOne(d => d.IdTerceroProveedorNavigation).WithMany(p => p.CntConfigContratos)
            .HasForeignKey(d => d.IdTerceroProveedor)
            .HasConstraintName("FK__cnt_contr__id_te__101A70C2");
    }
}
