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
    }
