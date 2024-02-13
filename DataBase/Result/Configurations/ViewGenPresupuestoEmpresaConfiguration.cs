using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenPresupuestoEmpresaConfiguration : IEntityTypeConfiguration<ViewGenPresupuestoEmpresa>
{
    public void Configure(EntityTypeBuilder<ViewGenPresupuestoEmpresa> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_presupuestoEmpresa");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaFinFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaFin_ff");
        builder.Property(e => e.FechaInicioFf)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaInicio_ff");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenEmpresaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_empresa_codigo");
        builder.Property(e => e.GenEmpresaCostoAdministrativoMes)
            .HasColumnType("money")
            .HasColumnName("gen_empresa_costoAdministrativoMes");
        builder.Property(e => e.GenEmpresaEmpresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_empresa_empresa");
        builder.Property(e => e.GenEmpresaEmpresaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_empresa_empresa_codigo");
        builder.Property(e => e.GenEmpresaIdEmpresa).HasColumnName("gen_empresa_id_empresa");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
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
    }
}
