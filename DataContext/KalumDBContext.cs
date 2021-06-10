using System.IO;
using Kalum21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Kalum21.DataContext
{
    public class KalumDBContext: DbContext
    {
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Roles> RolesApp { get; set; }
        public DbSet<Salones> Salones { get; set; }
        public DbSet<Horarios> Horarios { get; set; }
        public DbSet<Instructores> Instructores { get; set; }
        public DbSet<CarreraTecnica> CarrerasTecnicas { get; set; }
        public DbSet<Clases> Clases { get; set; }
        public KalumDBContext(DbContextOptions<KalumDBContext> options)
            : base(options)
        {
            
        }
        public KalumDBContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
                optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaulConnection"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumnos>()
                .ToTable("Alumnos")
                .HasKey(a => new {a.Carnet});

            modelBuilder.Entity<Usuarios>()
                .ToTable("UsuariosApp")
                .HasKey(b => new {b.Id});

            modelBuilder.Entity<Roles>()
                .ToTable("RolesApp")
                .HasKey(c => new {c.Id});
                
            modelBuilder.Entity<Salones>()
                .ToTable("Salones")
                .HasKey(d => new {d.SalonId});

            modelBuilder.Entity<Horarios>()
                .ToTable("Horarios")
                .HasKey(e => new {e.HorarioId});
            
            modelBuilder.Entity<Instructores>()
                .ToTable("Instructores")
                .HasKey(f => new {f.InstructorId});
            
            modelBuilder.Entity<CarreraTecnica>()
                .ToTable("CarrerasTecnicas")
                .HasKey(g => new {g.CarreraId});

            modelBuilder.Entity<Clases>()
                .ToTable("Clases")
                .HasKey(h => new {h.ClaseId});

            modelBuilder.Entity<Clases>()
                .HasOne<CarreraTecnica>(h => h.CarreraTecnica)
                .WithMany(ht => ht.Clases)
                .HasForeignKey(h => h.CarreraId);
        }
    }
}