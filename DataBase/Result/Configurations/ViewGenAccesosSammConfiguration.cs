using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewGenAccesosSammConfiguration : IEntityTypeConfiguration<ViewGenAccesosSamm>
{
    public void Configure(EntityTypeBuilder<ViewGenAccesosSamm> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_gen_accesosSamm");

        builder.Property(e => e.AccesosSamm)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("accesosSamm");
        builder.Property(e => e.AccesosSammCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("accesosSamm_codigo");
        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DireccionIp)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("direccionIP");
        builder.Property(e => e.Edita).HasColumnName("edita");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EsHijo).HasColumnName("esHijo");
        builder.Property(e => e.EsSalida).HasColumnName("esSalida");
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
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
