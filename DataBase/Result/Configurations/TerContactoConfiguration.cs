using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SAMMAI.DataBase.Repository.Entities;

namespace SAMMAI.DataBase.Repository.Configurations;

public class TerContactoConfiguration : IEntityTypeConfiguration<TerContacto>
{
    public void Configure(EntityTypeBuilder<TerContacto> builder)
    {
        builder.ToTable("ter_contacto");

        builder.HasIndex(e => e.Eid, "IX_ter_contacto");

        builder.Property(e => e.Id).HasColumnName("id");
        builder.Property(e => e.AccesoActivo)
            .HasDefaultValue(true)
            .HasColumnName("accesoActivo");
        builder.Property(e => e.Active)
            .HasDefaultValue(true)
            .HasColumnName("active");
        builder.Property(e => e.Cargo)
            .HasMaxLength(100)
            .HasColumnName("cargo");
        builder.Property(e => e.CodigoAcceso)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue(" ")
            .HasColumnName("codigoAcceso");
        builder.Property(e => e.Contacto)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasColumnName("contacto");
        builder.Property(e => e.ContactoCodigo)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("contacto_codigo");
        builder.Property(e => e.Direccion)
            .HasMaxLength(300)
            .IsUnicode(false)
            .HasDefaultValue("");
        builder.Property(e => e.Eid)
            .HasMaxLength(50)
            .IsUnicode(false)
            .HasColumnName("eid");
        builder.Property(e => e.Email)
            .HasMaxLength(100)
            .IsUnicode(false);
        builder.Property(e => e.Fax)
            .HasMaxLength(100)
            .IsUnicode(false);
        builder.Property(e => e.FechaCreacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("smalldatetime")
            .HasColumnName("fechaCreacion");
        builder.Property(e => e.FechaModificacion)
            .HasDefaultValueSql("(getdate())")
            .HasColumnType("datetime")
            .HasColumnName("fechaModificacion");
        builder.Property(e => e.IdCargoContacto).HasColumnName("id_cargoContacto");
        builder.Property(e => e.IdTercero).HasColumnName("id_tercero");
        builder.Property(e => e.IdUsuario).HasColumnName("id_usuario");
        builder.Property(e => e.IdUsuarioCreo).HasColumnName("id_usuario_creo");
        builder.Property(e => e.IdUsuarioModifico).HasColumnName("id_usuario_modifico");
        builder.Property(e => e.Telefono)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasDefaultValue("")
            .HasColumnName("telefono");
        builder.Property(e => e.TelefonoMovil)
            .HasMaxLength(100)
            .IsUnicode(false)
            .HasColumnName("telefonoMovil");
        builder.Property(e => e.TerCargoContactoIdUsuarioCreo).HasColumnName("ter_cargoContacto_id_usuario_Creo");
        builder.Property(e => e.TerCargoContactoIdUsuarioModifico).HasColumnName("ter_cargoContacto_id_usuario_Modifico");
        builder.Property(e => e.Uid)
            .HasMaxLength(500)
            .IsUnicode(false)
            .HasColumnName("uid");

        builder.HasOne(d => d.IdTerceroNavigation).WithMany(p => p.TerContactos)
            .HasForeignKey(d => d.IdTercero)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_contacto_id_tercero");

        builder.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.TerContactos)
            .HasForeignKey(d => d.IdUsuario)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_ter_contacto_id_usuario");
    }
}
