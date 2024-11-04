using Microsoft.EntityFrameworkCore;
using MedicationSchedule.DataAccess.Entities;

namespace MedicationSchedule.DataAccess;

public class MedicationScheduleDbContext : DbContext
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<RoleEntity> Roles { get; set; }
    public DbSet<PlanEntity> Plans { get; set; }
    
    public MedicationScheduleDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<UserEntity>().HasMany(x => x.PlansAsPatient)
            .WithOne(x => x.Patient)
            .HasForeignKey(x => x.PatientId)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<UserEntity>().HasMany(x => x.PlansAsDoctor)
            .WithOne(x => x.Doctor)
            .HasForeignKey(x => x.DoctorId)
            .OnDelete(DeleteBehavior.Restrict);
        

        modelBuilder.Entity<RoleEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<RoleEntity>().HasMany(x => x.Users)
            .WithOne(x => x.Role)
            .HasForeignKey(x => x.RoleId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<PlanEntity>().HasKey(x => x.Id);
        modelBuilder.Entity<PlanEntity>().HasOne(x => x.Doctor)
            .WithMany(x => x.PlansAsDoctor)
            .HasForeignKey(x => x.DoctorId);
        modelBuilder.Entity<PlanEntity>().HasOne(x => x.Patient)
            .WithMany(x => x.PlansAsPatient)
            .HasForeignKey(x => x.PatientId);
    }
}