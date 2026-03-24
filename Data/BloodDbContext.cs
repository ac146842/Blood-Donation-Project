using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Blood_Donation_Project.Models;

    public class BloodDbContext : DbContext
    {
        public BloodDbContext (DbContextOptions<BloodDbContext> options)
            : base(options)
        {
        }

        public DbSet<Blood_Donation_Project.Models.Donor> Donor { get; set; } = default!;

public DbSet<Blood_Donation_Project.Models.Appointment> Appointment { get; set; } = default!;

public DbSet<Blood_Donation_Project.Models.BloodTypeTable> BloodTypeTable { get; set; } = default!;

public DbSet<Blood_Donation_Project.Models.DonatedBlood> DonatedBlood { get; set; } = default!;

public DbSet<Blood_Donation_Project.Models.FormAnswers> FormAnswers { get; set; } = default!;

public DbSet<Blood_Donation_Project.Models.FormQuestions> FormQuestions { get; set; } = default!;

public DbSet<Blood_Donation_Project.Models.Inventory> Inventory { get; set; } = default!;

public DbSet<Blood_Donation_Project.Models.MedicalForm> MedicalForm { get; set; } = default!;

public DbSet<Blood_Donation_Project.Models.Nurse> Nurse { get; set; } = default!;
    }
