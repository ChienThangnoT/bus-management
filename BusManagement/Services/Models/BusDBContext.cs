using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Services.Models
{
    public partial class BusDBContext : DbContext
    {
        public BusDBContext()
        {
        }

        public BusDBContext(DbContextOptions<BusDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblAccount> TblAccounts { get; set; }
        public virtual DbSet<TblBu> TblBus { get; set; }
        public virtual DbSet<TblBusRoute> TblBusRoutes { get; set; }
        public virtual DbSet<TblDriver> TblDrivers { get; set; }
        public virtual DbSet<TblTransportUnit> TblTransportUnits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }
        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:BusDB"];
            return strConn;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<TblAccount>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.ToTable("tblAccount");

                entity.Property(e => e.AccountId)
                    .HasMaxLength(50)
                    .HasColumnName("account_id");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.FullName)
                    .HasMaxLength(40)
                    .HasColumnName("full_name");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Password)
                    .HasMaxLength(30)
                    .HasColumnName("password");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(12)
                    .HasColumnName("phone_number");

                entity.Property(e => e.Role)
                    .HasMaxLength(30)
                    .HasColumnName("role");

                entity.Property(e => e.Username)
                    .HasMaxLength(30)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<TblBu>(entity =>
            {
                entity.HasKey(e => e.BusId);

                entity.ToTable("tblBus");

                entity.Property(e => e.BusId)
                    .HasMaxLength(10)
                    .HasColumnName("bus_id");

                entity.Property(e => e.BusType)
                    .HasMaxLength(15)
                    .HasColumnName("bus_type");

                entity.Property(e => e.EngineOuput).HasColumnName("engine_ouput");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnType("datetime")
                    .HasColumnName("registration_date");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.ManufacturingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("manufacturing_date");

                entity.Property(e => e.NumberPlate)
                    .HasMaxLength(10)
                    .HasColumnName("number_plate");

                entity.Property(e => e.PeriodicMaintenance).HasColumnName("periodic_maintenance");

                entity.Property(e => e.RoutesId)
                    .HasMaxLength(10)
                    .HasColumnName("routes_id");

                entity.Property(e => e.SeatQuantity).HasColumnName("seat_quantity");

                entity.HasOne(d => d.Routes)
                    .WithMany(p => p.TblBus)
                    .HasForeignKey(d => d.RoutesId)
                    .HasConstraintName("FK_tblBus_tblBusRoutes");
            });

            modelBuilder.Entity<TblBusRoute>(entity =>
            {
                entity.HasKey(e => e.RoutesId);

                entity.ToTable("tblBusRoutes");

                entity.Property(e => e.RoutesId)
                    .HasMaxLength(10)
                    .HasColumnName("routes_id");

                entity.Property(e => e.EndPoint)
                    .HasMaxLength(100)
                    .HasColumnName("end_point");

                entity.Property(e => e.EndTime).HasColumnName("end_time");

                entity.Property(e => e.EstimatedTime).HasColumnName("estimated_time");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.RoutesName)
                    .HasMaxLength(50)
                    .HasColumnName("routes_name");

                entity.Property(e => e.StartPoint)
                    .HasMaxLength(100)
                    .HasColumnName("start_point");

                entity.Property(e => e.StartTime).HasColumnName("start_time");

                entity.Property(e => e.TransportUnitId)
                    .HasMaxLength(10)
                    .HasColumnName("transport_unit_id");

                entity.HasOne(d => d.TransportUnit)
                    .WithMany(p => p.TblBusRoutes)
                    .HasForeignKey(d => d.TransportUnitId)
                    .HasConstraintName("FK_tblBusRoutes_tblTransportUnit");
            });

            modelBuilder.Entity<TblDriver>(entity =>
            {
                entity.HasKey(e => e.DriverId);

                entity.ToTable("tblDriver");

                entity.Property(e => e.DriverId)
                    .HasMaxLength(10)
                    .HasColumnName("driver_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .HasColumnName("address");

                entity.Property(e => e.BusId)
                    .HasMaxLength(10)
                    .HasColumnName("bus_id");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("dob");

                entity.Property(e => e.DriverName)
                    .HasMaxLength(40)
                    .HasColumnName("driver_name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .HasColumnName("gender");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.Salary)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("salary");

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("start_date");

                entity.HasOne(d => d.Bus)
                    .WithMany(p => p.TblDrivers)
                    .HasForeignKey(d => d.BusId)
                    .HasConstraintName("FK_tblDriver_tblBus");
            });

            modelBuilder.Entity<TblTransportUnit>(entity =>
            {
                entity.HasKey(e => e.TransportUnitId);

                entity.ToTable("tblTransportUnit");

                entity.Property(e => e.TransportUnitId)
                    .HasMaxLength(10)
                    .HasColumnName("transport_unit_id");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .HasColumnName("address");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(12)
                    .HasColumnName("phone_number");

                entity.Property(e => e.TransportUnitName)
                    .HasMaxLength(50)
                    .HasColumnName("transport_unit_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
