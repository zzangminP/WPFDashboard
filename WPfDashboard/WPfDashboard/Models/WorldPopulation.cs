using System;
using System.Collections.Generic;

namespace WPfDashboard.Models;

public partial class WorldPopulation
{
    public int Id { get; set; }

    public string CountryName { get; set; } = null!;

    public string IsoCode { get; set; } = null!;

    public string? Region { get; set; }

    public long? Population { get; set; }

    public long? AreaKm2 { get; set; }

    public long? Gdp { get; set; }

    public decimal? GdpPerCapita { get; set; }

    public decimal? BirthRate { get; set; }

    public decimal? DeathRate { get; set; }

    public decimal? LifeExpectancy { get; set; }
}
