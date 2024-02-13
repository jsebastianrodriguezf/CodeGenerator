using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class ViewEquOpcionAtributoDependienteConfiguration : IEntityTypeConfiguration<ViewEquOpcionAtributoDependiente>
{
    public void Configure(EntityTypeBuilder<ViewEquOpcionAtributoDependiente> builder)
    {
        builder
            .HasNoKey()
            .ToView("view_equ_opcionAtributoDependiente");

        builder.Property(e => e.Active).HasColumnName("active");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.EquOpcionAtributoHijoIdAtributo).HasColumnName("equ_opcionAtributo_hijo_id_atributo");
        builder.Property(e => e.EquOpcionAtributoHijoOpcionAtributo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_opcionAtributo_hijo_opcionAtributo");
        builder.Property(e => e.EquOpcionAtributoHijoOpcionAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_opcionAtributo_hijo_opcionAtributo_codigo");
        builder.Property(e => e.EquOpcionAtributoHijoOrden).HasColumnName("equ_opcionAtributo_hijo_orden");
        builder.Property(e => e.EquOpcionAtributoPadreIdAtributo).HasColumnName("equ_opcionAtributo_padre_id_atributo");
        builder.Property(e => e.EquOpcionAtributoPadreOpcionAtributo)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("equ_opcionAtributo_padre_opcionAtributo");
        builder.Property(e => e.EquOpcionAtributoPadreOpcionAtributoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("equ_opcionAtributo_padre_opcionAtributo_codigo");
        builder.Property(e => e.EquOpcionAtributoPadreOrden).HasColumnName("equ_opcionAtributo_padre_orden");
        builder.Property(e => e.FechaCreacion)
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.IdOpcionAtributoHijo).HasColumnName("id_opcionAtributo_hijo");
        builder.Property(e => e.IdOpcionAtributoPadre).HasColumnName("id_opcionAtributo_padre");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Multiempresa)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("multiempresa");
        builder.Property(e => e.OpcionAtributoDependiente)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("opcionAtributoDependiente");
        builder.Property(e => e.OpcionAtributoDependienteCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("opcionAtributoDependiente_codigo");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");
    }
}
