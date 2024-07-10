using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using conc.Repositories.Models;

namespace conc.Repositories;
using DotNetEnv;

public partial class InvEntities : DbContext
{
    public InvEntities()
    {
    }

    public InvEntities(DbContextOptions<InvEntities> options)
        : base(options)
    {
    }

    public virtual DbSet<ImageAndFp> ImageAndFps { get; set; }

    public virtual DbSet<ImageFace> ImageFaces { get; set; }

    public virtual DbSet<ImageFp> ImageFps { get; set; }

    public virtual DbSet<Invest> Invests { get; set; }

    public virtual DbSet<Invperson> Invpersons { get; set; }

    public virtual DbSet<Nation> Nations { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<Village> Villages { get; set; }

    public virtual DbSet<Worldkey> Worldkeys { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        Env.Load();
        var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ImageAndFp>(entity =>
        {
            entity.HasKey(e => new { e.Serial, e.Serpers }).HasName("PK__ImageAnd__C87A60D564727F3A");
        });

        modelBuilder.Entity<ImageFace>(entity =>
        {
            entity.HasKey(e => new { e.Serial, e.Serpers }).HasName("PK__ImageFac__52B352DE53E117C7");
        });

        modelBuilder.Entity<ImageFp>(entity =>
        {
            entity.HasKey(e => new { e.Serial, e.Serpers }).HasName("PK__ImageFP__52B352DE0B05CF8F");
        });

        modelBuilder.Entity<Invest>(entity =>
        {
            entity.HasKey(e => e.Serial).HasName("PK__INVEST__1CE6D4E6075A6F21");

            entity.Property(e => e.Serial).ValueGeneratedNever();
        });

        modelBuilder.Entity<Invperson>(entity =>
        {
            entity.HasKey(e => new { e.Serial, e.Serpers }).HasName("PK__invperso__52B352DE2DE9795A");
        });

        modelBuilder.Entity<Nation>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__nations__AA1D437890CAF380");

            entity.Property(e => e.Code).ValueGeneratedNever();
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Vid).HasName("PK__vehicles__DDB00C7D03F7C139");

            entity.Property(e => e.Vid).ValueGeneratedNever();
        });

        modelBuilder.Entity<Village>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__Village__AA1D437859801488");

            entity.Property(e => e.Code).ValueGeneratedNever();
            entity.Property(e => e.Label).IsFixedLength();
        });

        modelBuilder.Entity<Worldkey>(entity =>
        {
            entity.HasKey(e => e.Code).HasName("PK__worldkey__AA1D4378A1EA5B05");

            entity.Property(e => e.Code).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
