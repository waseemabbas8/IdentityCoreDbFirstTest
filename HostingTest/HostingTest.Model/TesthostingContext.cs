using System;
using HostingTest.Data.Models;
using HostingTest.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HostingTest.Data.HostingTest.Model
{
    public class TesthostingContext : IdentityDbContext<ApplicationUser>
    {
        public TesthostingContext()
        {
        }

        public TesthostingContext(DbContextOptions<TesthostingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Student> Student { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

        //    //modelBuilder.Entity<AspNetUsers>(entity =>
        //    //{
        //    //    entity.HasIndex(e => e.NormalizedEmail)
        //    //        .HasName("EmailIndex");

        //    //    entity.HasIndex(e => e.NormalizedUserName)
        //    //        .HasName("UserNameIndex")
        //    //        .IsUnique()
        //    //        .HasFilter("([NormalizedUserName] IS NOT NULL)");

        //    //    entity.Property(e => e.Id).ValueGeneratedNever();

        //    //    entity.Property(e => e.Email).HasMaxLength(256);

        //    //    entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

        //    //    entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

        //    //    entity.Property(e => e.UserName).HasMaxLength(256);
        //    //});

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}