using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class DocEstrategiaPrioridadConfiguration : IEntityTypeConfiguration<DocEstrategiaPrioridad>
{
    public void Configure(EntityTypeBuilder<DocEstrategiaPrioridad> builder)
    {
        builder.ToTable("doc_estrategiaPrioridad");

        builder.HasIndex(e => e.Eid, "IX_doc_estrategiaPrioridad");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.DomingoFinHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("domingoFin_hh");
        builder.Property(e => e.DomingoIniHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
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
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.FestivoFinHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("festivoFin_hh");
        builder.Property(e => e.FestivoIniHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("festivoIni_hh");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.JuevesFinHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("juevesFin_hh");
        builder.Property(e => e.JuevesIniHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("juevesIni_hh");
        builder.Property(e => e.LunesFinHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("lunesFin_hh");
        builder.Property(e => e.LunesIniHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("lunesIni_hh");
        builder.Property(e => e.MartesFinHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("martesFin_hh");
        builder.Property(e => e.MartesIniHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("martesIni_hh");
        builder.Property(e => e.MiercolesFinHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("miercolesFin_hh");
        builder.Property(e => e.MiercolesIniHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("miercolesIni_hh");
        builder.Property(e => e.SabadoFinHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("sabadoFin_hh");
        builder.Property(e => e.SabadoIniHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("sabadoIni_hh");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
        builder.Property(e => e.ViernesFinHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("viernesFin_hh");
        builder.Property(e => e.ViernesIniHh)
            .HasDefaultValueSql("(((1)/(1))/(1900))")
            .HasColumnType("smalldatetime")
            .HasColumnName("viernesIni_hh");
    }
}
