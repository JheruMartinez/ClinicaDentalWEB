using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ClinicaDentalWEB.Models;

public partial class BkclinicaDentalContext : DbContext
{
    public BkclinicaDentalContext()
    {
    }

    public BkclinicaDentalContext(DbContextOptions<BkclinicaDentalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Citum> Cita { get; set; }

    public virtual DbSet<Consultum> Consulta { get; set; }

    public virtual DbSet<Dentistum> Dentista { get; set; }

    public virtual DbSet<DetalleFactura> DetalleFacturas { get; set; }

    public virtual DbSet<Especialidad> Especialidads { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<HistorialMedico> HistorialMedicos { get; set; }

    public virtual DbSet<HorarioTrabajo> HorarioTrabajos { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<PermisosRolPermiso> PermisosRolPermisos { get; set; }

    public virtual DbSet<PermisosRolRol> PermisosRolRols { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<RolUsuarioRol> RolUsuarioRols { get; set; }

    public virtual DbSet<RolUsuarioUsuario> RolUsuarioUsuarios { get; set; }

    public virtual DbSet<SeguroMedico> SeguroMedicos { get; set; }

    public virtual DbSet<Tratamiento> Tratamientos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-JO72MDD;Database=ClinicaDentalBD;Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Citum>(entity =>
        {
            entity.HasKey(e => e.IdCita).HasName("PK__Cita__6AEC3C0983C84AE2");

            entity.Property(e => e.IdCita)
                .ValueGeneratedNever()
                .HasColumnName("id_cita");
            entity.Property(e => e.Duracion)
                .HasMaxLength(255)
                .HasColumnName("duracion");
            entity.Property(e => e.Estado)
                .HasMaxLength(255)
                .HasColumnName("estado");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Hora).HasColumnName("hora");
            entity.Property(e => e.IdDentista).HasColumnName("id_dentista");
            entity.Property(e => e.IdPaciente).HasColumnName("id_paciente");
            entity.Property(e => e.IdTratamiento).HasColumnName("id_tratamiento");
            entity.Property(e => e.Motivo)
                .HasMaxLength(255)
                .HasColumnName("motivo");

            entity.HasOne(d => d.IdDentistaNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdDentista)
                .HasConstraintName("FK__Cita__id_dentist__693CA210");

            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdPaciente)
                .HasConstraintName("FK__Cita__id_pacient__6A30C649");

            entity.HasOne(d => d.IdTratamientoNavigation).WithMany(p => p.Cita)
                .HasForeignKey(d => d.IdTratamiento)
                .HasConstraintName("FK__Cita__id_tratami__72C60C4A");
        });

        modelBuilder.Entity<Consultum>(entity =>
        {
            entity.HasKey(e => e.IdConsulta).HasName("PK__Consulta__6F53588BE0BAE923");

            entity.Property(e => e.IdConsulta)
                .ValueGeneratedNever()
                .HasColumnName("id_consulta");
            entity.Property(e => e.Diagnostico)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IdCita).HasColumnName("id_cita");
            entity.Property(e => e.IdTratamiento).HasColumnName("id_tratamiento");
            entity.Property(e => e.Observaciones).HasColumnType("text");

            entity.HasOne(d => d.IdCitaNavigation).WithMany(p => p.Consulta)
                .HasForeignKey(d => d.IdCita)
                .HasConstraintName("FK__Consulta__id_cit__6B24EA82");

            entity.HasOne(d => d.IdTratamientoNavigation).WithMany(p => p.Consulta)
                .HasForeignKey(d => d.IdTratamiento)
                .HasConstraintName("FK__Consulta__id_tra__6C190EBB");
        });

        modelBuilder.Entity<Dentistum>(entity =>
        {
            entity.HasKey(e => e.IdDentista).HasName("PK__Dentista__34FFEAA521B09A3B");

            entity.Property(e => e.IdDentista)
                .ValueGeneratedNever()
                .HasColumnName("id_dentista");
            entity.Property(e => e.Apellido)
                .HasMaxLength(255)
                .HasColumnName("apellido");
            entity.Property(e => e.Apellido2)
                .HasMaxLength(255)
                .HasColumnName("apellido2");
            entity.Property(e => e.DiasConsultas)
                .HasMaxLength(255)
                .HasColumnName("diasConsultas");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Exequatur)
                .HasColumnType("image")
                .HasColumnName("exequatur");
            entity.Property(e => e.Genero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("genero");
            entity.Property(e => e.IdEspecialidad).HasColumnName("id_especialidad");
            entity.Property(e => e.IdHorario).HasColumnName("id_horario");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(255)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.Pais)
                .HasMaxLength(255)
                .HasColumnName("pais");
            entity.Property(e => e.Telefono)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<DetalleFactura>(entity =>
        {
            entity.HasKey(e => e.IdDetalleFactura).HasName("PK__DetalleF__48255F7E6377AC75");

            entity.ToTable("DetalleFactura");

            entity.Property(e => e.IdDetalleFactura)
                .ValueGeneratedNever()
                .HasColumnName("id_detalleFactura");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.IdTratamiento).HasColumnName("id_tratamiento");
            entity.Property(e => e.PrecioUnitario)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("precioUnitario");
            entity.Property(e => e.Subtotal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("subtotal");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.DetalleFacturas)
                .HasForeignKey(d => d.IdFactura)
                .HasConstraintName("FK__DetalleFa__id_fa__6E01572D");

            entity.HasOne(d => d.IdTratamientoNavigation).WithMany(p => p.DetalleFacturas)
                .HasForeignKey(d => d.IdTratamiento)
                .HasConstraintName("FK__DetalleFa__id_tr__6EF57B66");
        });

        modelBuilder.Entity<Especialidad>(entity =>
        {
            entity.HasKey(e => e.IdEspecialidad).HasName("PK__Especial__C1D13763D6FF0922");

            entity.ToTable("Especialidad");

            entity.Property(e => e.IdEspecialidad)
                .ValueGeneratedNever()
                .HasColumnName("id_especialidad");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PK__Factura__6C08ED5355ED11BA");

            entity.ToTable("Factura");

            entity.Property(e => e.IdFactura)
                .ValueGeneratedNever()
                .HasColumnName("id_factura");
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.FechaEmision).HasColumnName("fechaEmision");
            entity.Property(e => e.IdPaciente).HasColumnName("id_paciente");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total");

            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdPaciente)
                .HasConstraintName("FK__Factura__id_paci__6D0D32F4");
        });

        modelBuilder.Entity<HistorialMedico>(entity =>
        {
            entity.HasKey(e => e.IdHm).HasName("PK__Historia__00B7E65166A70724");

            entity.ToTable("HistorialMedico");

            entity.Property(e => e.IdHm)
                .ValueGeneratedNever()
                .HasColumnName("id_hm");
            entity.Property(e => e.Diagnostico)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("diagnostico");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.IdConsulta).HasColumnName("id_consulta");
            entity.Property(e => e.IdPaciente).HasColumnName("id_paciente");
            entity.Property(e => e.IdTratamiento).HasColumnName("id_tratamiento");
            entity.Property(e => e.Observaciones)
                .HasColumnType("text")
                .HasColumnName("observaciones");
            entity.Property(e => e.Procedimiento)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.IdConsultaNavigation).WithMany(p => p.HistorialMedicos)
                .HasForeignKey(d => d.IdConsulta)
                .HasConstraintName("FK__Historial__id_co__71D1E811");

            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.HistorialMedicos)
                .HasForeignKey(d => d.IdPaciente)
                .HasConstraintName("FK__Historial__id_pa__6FE99F9F");

            entity.HasOne(d => d.IdTratamientoNavigation).WithMany(p => p.HistorialMedicos)
                .HasForeignKey(d => d.IdTratamiento)
                .HasConstraintName("FK__Historial__id_tr__70DDC3D8");
        });

        modelBuilder.Entity<HorarioTrabajo>(entity =>
        {
            entity.HasKey(e => e.IdHorario).HasName("PK__HorarioT__C5836D6947524288");

            entity.ToTable("HorarioTrabajo");

            entity.Property(e => e.IdHorario)
                .ValueGeneratedNever()
                .HasColumnName("id_horario");
            entity.Property(e => e.DiaSemana)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IdDentista).HasColumnName("id_dentista");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.IdPaciente).HasName("PK__Paciente__2C2C72BB407E1A7E");

            entity.ToTable("Paciente");

            entity.Property(e => e.IdPaciente)
                .ValueGeneratedNever()
                .HasColumnName("id_paciente");
            entity.Property(e => e.Alergias)
                .HasMaxLength(255)
                .HasColumnName("alergias");
            entity.Property(e => e.Apellido1)
                .HasMaxLength(255)
                .HasColumnName("apellido1");
            entity.Property(e => e.Apellido2)
                .HasMaxLength(255)
                .HasColumnName("apellido2");
            entity.Property(e => e.Direccion)
                .HasMaxLength(255)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.FechaNac)
                .HasMaxLength(255)
                .HasColumnName("fecha_nac");
            entity.Property(e => e.Genero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("genero");
            entity.Property(e => e.Identificacion)
                .HasMaxLength(255)
                .HasColumnName("identificacion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(255)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoSangre)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("tipoSangre");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.IdPago).HasName("PK__Pago__0941B0744CCA8D21");

            entity.ToTable("Pago");

            entity.Property(e => e.IdPago)
                .ValueGeneratedNever()
                .HasColumnName("id_pago");
            entity.Property(e => e.Detalles)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detalles");
            entity.Property(e => e.EstadoPago)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("estadoPago");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("fecha");
            entity.Property(e => e.IdFactura).HasColumnName("id_factura");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("metodoPago");
            entity.Property(e => e.Monto)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("monto");

            entity.HasOne(d => d.IdFacturaNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.IdFactura)
                .HasConstraintName("FK__Pago__id_factura__74AE54BC");
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => e.IdPermiso).HasName("PK__Permiso__228F224FB71EF47F");

            entity.ToTable("Permiso");

            entity.Property(e => e.IdPermiso)
                .ValueGeneratedNever()
                .HasColumnName("id_permiso");
            entity.Property(e => e.ActualizadoPor).HasColumnName("actualizado_por");
            entity.Property(e => e.CreadoPor).HasColumnName("creado_por");
            entity.Property(e => e.Description)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.ActualizadoPorNavigation).WithMany(p => p.PermisoActualizadoPorNavigations)
                .HasForeignKey(d => d.ActualizadoPor)
                .HasConstraintName("FK__Permiso__actuali__778AC167");

            entity.HasOne(d => d.CreadoPorNavigation).WithMany(p => p.PermisoCreadoPorNavigations)
                .HasForeignKey(d => d.CreadoPor)
                .HasConstraintName("FK__Permiso__creado___787EE5A0");
        });

        modelBuilder.Entity<PermisosRolPermiso>(entity =>
        {
            entity.HasKey(e => new { e.PermisosRolIdPermiso, e.PermisoIdPermiso }).HasName("PK__Permisos__DDDFE11E6DFF86D2");

            entity.ToTable("Permisos_Rol_Permiso");

            entity.Property(e => e.PermisosRolIdPermiso).HasColumnName("Permisos_Rol_id_permiso");
            entity.Property(e => e.PermisoIdPermiso).HasColumnName("Permiso_id_permiso");

            entity.HasOne(d => d.PermisoIdPermisoNavigation).WithMany(p => p.PermisosRolPermisos)
                .HasForeignKey(d => d.PermisoIdPermiso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Permisos___Permi__00200768");
        });

        modelBuilder.Entity<PermisosRolRol>(entity =>
        {
            entity.HasKey(e => new { e.PermisosRolIdRol, e.RolIdRol }).HasName("PK__Permisos__D4089D552503AD64");

            entity.ToTable("Permisos_Rol_Rol");

            entity.Property(e => e.PermisosRolIdRol).HasColumnName("Permisos_Rol_id_rol");
            entity.Property(e => e.RolIdRol).HasColumnName("Rol_id_rol");

            entity.HasOne(d => d.RolIdRolNavigation).WithMany(p => p.PermisosRolRols)
                .HasForeignKey(d => d.RolIdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Permisos___Rol_i__7C4F7684");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__Rol__6ABCB5E077A4BFC1");

            entity.ToTable("Rol");

            entity.Property(e => e.IdRol)
                .ValueGeneratedNever()
                .HasColumnName("id_rol");
            entity.Property(e => e.ActualizadoPor).HasColumnName("actualizado_por");
            entity.Property(e => e.CreadoPor).HasColumnName("creado_por");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("descripcion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.ActualizadoPorNavigation).WithMany(p => p.RolActualizadoPorNavigations)
                .HasForeignKey(d => d.ActualizadoPor)
                .HasConstraintName("FK__Rol__actualizado__75A278F5");

            entity.HasOne(d => d.CreadoPorNavigation).WithMany(p => p.RolCreadoPorNavigations)
                .HasForeignKey(d => d.CreadoPor)
                .HasConstraintName("FK__Rol__creado_por__76969D2E");
        });

        modelBuilder.Entity<RolUsuarioRol>(entity =>
        {
            entity.HasKey(e => new { e.RolUsuarioIdRol, e.RolIdRol }).HasName("PK__Rol_Usua__14E1DF2D5E8A54CA");

            entity.ToTable("Rol_Usuario_Rol");

            entity.Property(e => e.RolUsuarioIdRol).HasColumnName("Rol_Usuario_id_rol");
            entity.Property(e => e.RolIdRol).HasColumnName("Rol_id_rol");

            entity.HasOne(d => d.RolIdRolNavigation).WithMany(p => p.RolUsuarioRols)
                .HasForeignKey(d => d.RolIdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Rol_Usuar__Rol_i__07C12930");
        });

        modelBuilder.Entity<RolUsuarioUsuario>(entity =>
        {
            entity.HasKey(e => new { e.RolUsuarioIdUsuario, e.UsuarioIdUsuario }).HasName("PK__Rol_Usua__1E4A07B9910034EE");

            entity.ToTable("Rol_Usuario_Usuario");

            entity.Property(e => e.RolUsuarioIdUsuario).HasColumnName("Rol_Usuario_id_usuario");
            entity.Property(e => e.UsuarioIdUsuario).HasColumnName("Usuario_id_usuario");

            entity.HasOne(d => d.UsuarioIdUsuarioNavigation).WithMany(p => p.RolUsuarioUsuarios)
                .HasForeignKey(d => d.UsuarioIdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Rol_Usuar__Usuar__03F0984C");
        });

        modelBuilder.Entity<SeguroMedico>(entity =>
        {
            entity.HasKey(e => e.IdSeguro).HasName("PK__SeguroMe__D187EEFE5A166DA0");

            entity.ToTable("SeguroMedico");

            entity.Property(e => e.IdSeguro)
                .ValueGeneratedNever()
                .HasColumnName("id_seguro");
            entity.Property(e => e.Cobertura)
                .HasMaxLength(255)
                .HasColumnName("cobertura");
            entity.Property(e => e.CodigoSeguro)
                .HasMaxLength(255)
                .HasColumnName("codigoSeguro");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.IdPaciente).HasColumnName("id_paciente");
            entity.Property(e => e.NombreSeguro)
                .HasMaxLength(255)
                .HasColumnName("nombreSeguro");
            entity.Property(e => e.Telefono)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("telefono");

            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.SeguroMedicos)
                .HasForeignKey(d => d.IdPaciente)
                .HasConstraintName("FK__SeguroMed__id_pa__73BA3083");
        });

        modelBuilder.Entity<Tratamiento>(entity =>
        {
            entity.HasKey(e => e.IdTratamiento).HasName("PK__Tratamie__C8825F4CF06647F5");

            entity.ToTable("Tratamiento");

            entity.Property(e => e.IdTratamiento)
                .ValueGeneratedNever()
                .HasColumnName("id_tratamiento");
            entity.Property(e => e.Costo)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("costo");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .HasColumnName("descripcion");
            entity.Property(e => e.Duracion).HasColumnName("duracion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__4E3E04AD1B7E97D1");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("id_usuario");
            entity.Property(e => e.Contra)
                .HasMaxLength(255)
                .HasColumnName("contra");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.FechaCreacion).HasColumnName("fecha_creacion");
            entity.Property(e => e.Usuario1)
                .HasMaxLength(255)
                .HasColumnName("usuario");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
