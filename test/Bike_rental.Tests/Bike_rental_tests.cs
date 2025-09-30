using Bike_rental.Models;

namespace Bike_rental.Tests;

/// <summary>
/// Unit tests for BikeRental.Models.
/// </summary>
public class BikeRentalTests(BikeRentalDataSeed seed) : IClassFixture<BikeRentalDataSeed>
{
    /// <summary>
    /// Test that retrieves information about all sport bicycles.
    /// </summary>
    [Fact]
    public void GetAllSportBicycles()
    {
        var sportBicycles = (from b in seed.Bicycles
                             join m in seed.BikeModels on b.ModelId equals m.ModelId
                             where m.Type == BikeType.Mountain || m.Type == BikeType.Road
                             select b)
                             .ToList();

        Assert.NotNull(sportBicycles);
        Assert.True(sportBicycles.Count >= 6); // Expecting at least 6 (4 Mountain, 2 Road from BikeModels)
    }

    /// <summary>
    /// Test that retrieves top 5 bike models by rental duration.
    /// </summary>
    [Fact]
    public void GetTop5BikeModelsByRentalDuration()
    {
        var currentDate = DateTime.Now; // Use current date and time
        var top5ByDuration = (from r in seed.RentalContracts
                              join b in seed.Bicycles on r.BicycleSerialNumber equals b.SerialNumber
                              join m in seed.BikeModels on b.ModelId equals m.ModelId
                              where r.StartTime <= currentDate
                              group r by m.ModelId into g
                              select new
                              {
                                  ModelId = g.Key,
                                  TotalDuration = g.Sum(x => x.RentalDurationHours)
                              })
                              .OrderByDescending(x => x.TotalDuration)
                              .Take(5)
                              .ToList();

        Assert.NotNull(top5ByDuration);
        Assert.Equal(5, top5ByDuration.Count); // Expecting 5 due to unique ModelIds
    }

        /// <summary>
        /// Test that retrieves top 5 bike models by rental profit.
        /// </summary>
        [Fact]
        public void GetTop5BikeModelsByRentalProfit()
        {
            var currentDate = new DateTime(2025, 10, 1); // Date after all seed rentals
            var top5ByProfit = (from r in seed.RentalContracts
                                join b in seed.Bicycles on r.BicycleSerialNumber equals b.SerialNumber
                                join m in seed.BikeModels on b.ModelId equals m.ModelId
                                where r.StartTime <= currentDate
                                group new { r, m } by m.ModelId into g
                                select new
                                {
                                    ModelId = g.Key,
                                    TotalProfit = g.Sum(x => x.m.HourlyRentalPrice * (decimal)x.r.RentalDurationHours)
                                })
                                .OrderByDescending(x => x.TotalProfit)
                                .Take(5)
                                .ToList();

            Assert.NotNull(top5ByProfit);
            Assert.Equal(5, top5ByProfit.Count);
        }

    /// <summary>
    /// Test that retrieves total rental time by bike type.
    /// </summary>
    [Fact]
    public void GetTotalRentalTimeByBikeType()
    {
        var currentDate = DateTime.Now; // Use current date and time
        var totalTimeByType = (from r in seed.RentalContracts
                               join b in seed.Bicycles on r.BicycleSerialNumber equals b.SerialNumber
                               join m in seed.BikeModels on b.ModelId equals m.ModelId
                               where r.StartTime <= currentDate
                               group r by m.Type into g
                               select new
                               {
                                   BikeType = g.Key,
                                   TotalDuration = g.Sum(x => x.RentalDurationHours)
                               })
                               .ToList();

        Assert.NotNull(totalTimeByType);
        Assert.True(totalTimeByType.Count >= 3); // Expecting at least Mountain, Road, Hybrid
    }

    /// <summary>
    /// Test that retrieves clients with the most rentals.
    /// </summary>
    [Fact]
    public void GetClientsWithMostRentals()
    {
        var topClients = seed.RentalContracts
            .GroupBy(r => r.RenterFullName)
            .Select(g => new
            {
                FullName = g.Key,
                RentalCount = g.Count()
            })
            .OrderByDescending(x => x.RentalCount)
            .Take(5)
            .ToList();

        Assert.NotNull(topClients);
        Assert.True(topClients.Count >= 1);
    }
}