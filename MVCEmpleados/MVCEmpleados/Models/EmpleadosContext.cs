using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MVCEmpleados.Models;

public partial class EmpleadosContext : DbContext
{
    public EmpleadosContext()
    {
    }

    public EmpleadosContext(DbContextOptions<EmpleadosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Empleado> Empleados { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {}
    }

//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//       => optionsBuilder.UseSqlServer("Server=DESKTOP-NST5V41\\SQLEXPRESS;Database=Empleados;integrated security=true;Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true;");

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Empleado>(entity =>
    {
        entity.HasKey(e => e.Id).HasName("PK__Empleado__3213E83F23E5444F");

        entity.Property(e => e.Id).HasColumnName("id");
        entity.Property(e => e.Apellido)
            .HasMaxLength(50)
            .IsUnicode(false);
        entity.Property(e => e.Nombre)
            .HasMaxLength(50)
            .IsUnicode(false);
        entity.Property(e => e.Puesto)
            .HasMaxLength(50)
            .IsUnicode(false);
    });

    OnModelCreatingPartial(modelBuilder);
}

partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
