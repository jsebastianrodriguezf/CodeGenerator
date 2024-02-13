using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenEmpresaConfiguration : IEntityTypeConfiguration<ViewGenEmpresa>
{
    public void Configure(EntityTypeBuilder<ViewGenEmpresa> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_empresa");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Codigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("codigo");
        builder.Property(e => e.CostoAdministrativoMes)
            .HasColumnType("money")
            .HasColumnName("costoAdministrativoMes");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Empresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("empresa");
        builder.Property(e => e.EmpresaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("empresa_codigo");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.GenEmpresaPadreCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_empresa_padre_codigo");
        builder.Property(e => e.GenEmpresaPadreCostoAdministrativoMes)
            .HasColumnType("money")
            .HasColumnName("gen_empresa_padre_costoAdministrativoMes");
        builder.Property(e => e.GenEmpresaPadreEmpresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("gen_empresa_padre_empresa");
        builder.Property(e => e.GenEmpresaPadreEmpresaCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("gen_empresa_padre_empresa_codigo");
        builder.Property(e => e.GenEmpresaPadreIdEmpresa).HasColumnName("gen_empresa_padre_id_empresa");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
