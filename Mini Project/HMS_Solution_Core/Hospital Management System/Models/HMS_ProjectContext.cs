using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hospital_Management_System.models
{
    public partial class HMS_ProjectContext : DbContext
    {
        public HMS_ProjectContext()
        {
        }

        public HMS_ProjectContext(DbContextOptions<HMS_ProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Appointment> Appointments { get; set; } = null!;
        public virtual DbSet<Billing> Billings { get; set; } = null!;
        public virtual DbSet<Consumable> Consumables { get; set; } = null!;
        public virtual DbSet<Patient> Patients { get; set; } = null!;
        public virtual DbSet<PatientDetail> PatientDetails { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Treatment> Treatments { get; set; } = null!;
        public virtual DbSet<UserTable> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=PLONDHE-LAP-072\\MSSQLSERVER01;initial catalog=HMS_Project;Integrated Security=SSPI");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("Appointment");

                entity.Property(e => e.AppointmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("appointment_id");

                entity.Property(e => e.AdmitDate).HasColumnType("date");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.TreatmentId).HasColumnName("treatment_id");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__Appointme__patie__35BCFE0A");

                entity.HasOne(d => d.Treatment)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.TreatmentId)
                    .HasConstraintName("FK__Appointme__treat__36B12243");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Appointme__userI__37A5467C");
            });

            modelBuilder.Entity<Billing>(entity =>
            {
                entity.HasKey(e => e.BillNumber)
                    .HasName("PK__Billing__7A1ADF1F666CDE36");

                entity.ToTable("Billing");

                entity.Property(e => e.BillNumber)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("bill_number");

                entity.Property(e => e.ConsumableId).HasColumnName("consumable_id");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.Consumable)
                    .WithMany(p => p.Billings)
                    .HasForeignKey(d => d.ConsumableId)
                    .HasConstraintName("FK__Billing__consuma__3B75D760");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Billings)
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__Billing__patient__3A81B327");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Billings)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Billing__userId__3C69FB99");
            });

            modelBuilder.Entity<Consumable>(entity =>
            {
                entity.ToTable("Consumable");

                entity.Property(e => e.ConsumableId)
                    .ValueGeneratedNever()
                    .HasColumnName("consumable_id");

                entity.Property(e => e.AvailabilityDetail)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("availability_detail");

                entity.Property(e => e.ConsumableName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("consumable_name");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.ToTable("Patient");

                entity.Property(e => e.PatientId)
                    .ValueGeneratedNever()
                    .HasColumnName("patient_id");

                entity.Property(e => e.PrevHistory)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("prev_history");

                entity.Property(e => e.Reports)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("reports");

                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Patient__userId__2C3393D0");
            });

            modelBuilder.Entity<PatientDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Patient_Details");

                entity.Property(e => e.DeseaseCatagory)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("desease_catagory");

                entity.Property(e => e.NoOfVisits).HasColumnName("no_of_visits");

                entity.Property(e => e.PatientId).HasColumnName("patient_id");

                entity.HasOne(d => d.Patient)
                    .WithMany()
                    .HasForeignKey(d => d.PatientId)
                    .HasConstraintName("FK__Patient_D__patie__2E1BDC42");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("role_id");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("roleName");
            });

            modelBuilder.Entity<Treatment>(entity =>
            {
                entity.ToTable("Treatment");

                entity.Property(e => e.TreatmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("treatment_id");

                entity.Property(e => e.ConsumableId).HasColumnName("consumable_id");

                entity.Property(e => e.IsAdmitted)
                    .HasMaxLength(1)
                    .HasColumnName("is_admitted")
                    .IsFixedLength();

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Consumable)
                    .WithMany(p => p.Treatments)
                    .HasForeignKey(d => d.ConsumableId)
                    .HasConstraintName("FK__Treatment__consu__32E0915F");
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.Property(e => e.UserId).HasColumnName("userId");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.ContactNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("contact_number");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("first_name");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.LastName)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.Password)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("password_");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.Specialization)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("specialization");

                entity.Property(e => e.StaffCategory)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("staff_category");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Users__role_id__29572725");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
