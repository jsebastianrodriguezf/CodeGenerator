using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewDocEstrategiaPrioridadConfiguration : IEntityTypeConfiguration<ViewDocEstrategiaPrioridad>
{
    public void Configure(EntityTypeBuilder<ViewDocEstrategiaPrioridad> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_doc_estrategiaPrioridad");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.DomingoFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("domingoFin_hh");
        builder.Property(e => e.DomingoIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("domingoIni_hh");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EstrategiaPrioridad)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("estrategiaPrioridad");
        builder.Property(e => e.EstrategiaPrioridadCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("estrategiaPrioridad_codigo");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FestivoFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("festivoFin_hh");
        builder.Property(e => e.FestivoIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("festivoIni_hh");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.JuevesFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("juevesFin_hh");
        builder.Property(e => e.JuevesIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("juevesIni_hh");
        builder.Property(e => e.LunesFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("lunesFin_hh");
        builder.Property(e => e.LunesIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("lunesIni_hh");
        builder.Property(e => e.MartesFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("martesFin_hh");
        builder.Property(e => e.MartesIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("martesIni_hh");
        builder.Property(e => e.MiercolesFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("miercolesFin_hh");
        builder.Property(e => e.MiercolesIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("miercolesIni_hh");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.SabadoFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("sabadoFin_hh");
        builder.Property(e => e.SabadoIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("sabadoIni_hh");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ViernesFinHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("viernesFin_hh");
        builder.Property(e => e.ViernesIniHh)
            .HasColumnType("smalldatetime")
            .HasColumnName("viernesIni_hh");
    }
}
