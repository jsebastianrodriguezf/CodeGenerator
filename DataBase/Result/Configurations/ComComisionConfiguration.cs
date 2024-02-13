using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ComComisionConfiguration : IEntityTypeConfiguration<ComComision>
{
    public void Configure(EntityTypeBuilder<ComComision> builder)
    {
        builder.ToTable("com_comision");

        builder.HasIndex(e => e.Eid, "IX_com_comision");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Comision)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("comision");
        builder.Property(e => e.ComisionCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("comision_codigo");
        builder.Property(e => e.Costear).HasColumnName("costear");
        builder.Property(e => e.DescuentoMaximo)
            .HasDefaultValue(0.0)
            .HasColumnName("descuentoMaximo");
        builder.Property(e => e.DescuentoMinimo)
            .HasDefaultValue(0.0)
            .HasColumnName("descuentoMinimo");
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
        builder.Property(e => e.IdCargo).HasColumnName("id_cargo");
        builder.Property(e => e.IdCondicion).HasColumnName("id_condicion");
        builder.Property(e => e.IdOpcionCondicion).HasColumnName("id_opcionCondicion");
        builder.Property(e => e.IdSubtipoCatalogo).HasColumnName("id_subtipoCatalogo");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.IdZona).HasColumnName("id_zona");
        builder.Property(e => e.Nivelnegocio).HasColumnName("nivelnegocio");
        builder.Property(e => e.PorcComision).HasColumnName("porc_comision");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdCargoNavigation).WithMany(p => p.ComComisions)
            .HasForeignKey(d => d.IdCargo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_com_comision_id_cargo");

        builder.HasOne(d => d.IdCondicionNavigation).WithMany(p => p.ComComisions)
            .HasForeignKey(d => d.IdCondicion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_com_comision_id_condicion");

        builder.HasOne(d => d.IdOpcionCondicionNavigation).WithMany(p => p.ComComisions)
            .HasForeignKey(d => d.IdOpcionCondicion)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_com_comision_id_opcionCondicion");

        builder.HasOne(d => d.IdSubtipoCatalogoNavigation).WithMany(p => p.ComComisions)
            .HasForeignKey(d => d.IdSubtipoCatalogo)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_com_comision_id_subtipoCatalogo");

        builder.HasOne(d => d.IdZonaNavigation).WithMany(p => p.ComComisions)
            .HasForeignKey(d => d.IdZona)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_com_comision_id_zona");
    }
}
