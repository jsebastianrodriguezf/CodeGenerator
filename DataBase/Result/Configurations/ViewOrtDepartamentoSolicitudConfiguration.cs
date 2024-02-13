using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewOrtDepartamentoSolicitudConfiguration : IEntityTypeConfiguration<ViewOrtDepartamentoSolicitud>
{
    public void Configure(EntityTypeBuilder<ViewOrtDepartamentoSolicitud> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_ort_departamentoSolicitud");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DepartamentoSolicitud)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("departamentoSolicitud");
        builder.Property(e => e.DepartamentoSolicitudCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("departamentoSolicitud_codigo");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.RecibeSolicitudes).HasColumnName("recibeSolicitudes");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
