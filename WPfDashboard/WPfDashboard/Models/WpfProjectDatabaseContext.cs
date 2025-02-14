using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WPfDashboard.Models;

public partial class WpfProjectDatabaseContext : DbContext
{
    public WpfProjectDatabaseContext()
    {
    }

    public WpfProjectDatabaseContext(DbContextOptions<WpfProjectDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<WorldPopulation> WorldPopulations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Database=WpfProjectDatabase;Username=postgres;Password=0000");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WorldPopulation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("world_population_pkey");

            entity.ToTable("world_population");

            entity.HasIndex(e => e.IsoCode, "world_population_iso_code_key").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AreaKm2).HasColumnName("area_km2");
            entity.Property(e => e.BirthRate)
                .HasPrecision(5, 2)
                .HasColumnName("birth_rate");
            entity.Property(e => e.CountryName)
                .HasMaxLength(100)
                .HasColumnName("country_name");
            entity.Property(e => e.DeathRate)
                .HasPrecision(5, 2)
                .HasColumnName("death_rate");
            entity.Property(e => e.Gdp).HasColumnName("gdp");
            entity.Property(e => e.GdpPerCapita)
                .HasPrecision(10, 2)
                .HasColumnName("gdp_per_capita");
            entity.Property(e => e.IsoCode)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("iso_code");
            entity.Property(e => e.LifeExpectancy)
                .HasPrecision(5, 2)
                .HasColumnName("life_expectancy");
            entity.Property(e => e.Population).HasColumnName("population");
            entity.Property(e => e.Region)
                .HasMaxLength(50)
                .HasColumnName("region");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
