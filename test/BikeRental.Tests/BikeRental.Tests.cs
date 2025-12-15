using BikeRental.Models;

namespace BikeRental.Tests;

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
        var expectedCount = 7;

        var sportBicycles = (from bicycle in seed.Bicycles
                             join model in seed.BikeModels on bicycle.ModelId equals model.Id
                             where model.Type == BikeType.Mountain || model.Type == BikeType.Road
                             select bicycle)
                             .ToList();

        Assert.NotNull(sportBicycles);
        Assert.Equal(expectedCount, sportBicycles.Count);
    }

    /// <summary>
    /// Test that retrieves top 5 bike models by rental duration.
    /// </summary>
    [Fact]
    public void GetTop5BikeModelsByRentalDuration()
    {
        var expectedCount = 5;

        var currentDate = new DateTime(2025, 10, 1);

        var top5ByDuration = (from rental in seed.RentalContracts
                              join bicycle in seed.Bicycles on rental.BicycleId equals bicycle.Id
                              join model in seed.BikeModels on bicycle.ModelId equals model.Id
                              where rental.StartTime <= currentDate
                              group rental by model.Id into g
                              select new
                              {
                                  ModelId = g.Key,
                                  TotalDuration = g.Sum(x => x.RentalDurationHours)
                              })
                             .OrderByDescending(x => x.TotalDuration)
                             .Take(5)
                             .ToList();


        Assert.NotNull(top5ByDuration);
        Assert.Equal(expectedCount, top5ByDuration.Count); 

        var expectedModelIds = new[] { 3, 9, 1, 8, 4 }; 
        var actualModelIds = top5ByDuration.Select(x => x.ModelId).ToList();
        Assert.Equal(expectedModelIds, actualModelIds);
    }

    /// <summary>
    /// Test that retrieves top 5 bike models by rental profit.
    /// </summary>
    [Fact]
    public void GetTop5BikeModelsByRentalProfit()
    {
        var expectedCount = 5;

        var currentDate = new DateTime(2025, 10, 1);
        var top5ByProfit = (from rental in seed.RentalContracts
                            join bicycle in seed.Bicycles on rental.BicycleId equals bicycle.Id
                            join model in seed.BikeModels on bicycle.ModelId equals model.Id
                            where rental.StartTime <= currentDate
                            group new { rental, model } by model.Id into g
                            select new
                            {
                                ModelId = g.Key,
                                TotalProfit = g.Sum(x => x.model.HourlyRentalPrice * (decimal)x.rental.RentalDurationHours)
                            })
                            .OrderByDescending(x => x.TotalProfit)
                            .Take(5)
                            .ToList();

        Assert.NotNull(top5ByProfit);
        Assert.Equal(expectedCount, top5ByProfit.Count);

        var expectedModelIds = new[] { 8, 9, 3, 1, 4 };
        var actualModelIds = top5ByProfit.Select(x => x.ModelId).ToList();
        Assert.Equal(expectedModelIds, actualModelIds);
    }

    /// <summary>
    /// Test that retrieves total rental time by bike type.
    /// </summary>
    [Fact]
    public void GetTotalRentalTimeByBikeType()
    {
        var expectedCount = 3;

        var currentDate = DateTime.Now; 
        var totalTimeByType = (from rental in seed.RentalContracts
                               join bicycle in seed.Bicycles on rental.BicycleId equals bicycle.Id
                               join model in seed.BikeModels on bicycle.ModelId equals model.Id
                               where rental.StartTime <= currentDate
                               group rental by model.Type into g
                               select new
                               {
                                   BikeType = g.Key,
                                   TotalDuration = g.Sum(x => x.RentalDurationHours)
                               })
                               .ToList();

        Assert.NotNull(totalTimeByType);
        Assert.Equal(expectedCount, totalTimeByType.Count);

        var expectedDurations = new[] { 5m, 7m, 8m };
        var actualDurations = totalTimeByType.Select(x => (decimal)x.TotalDuration).OrderBy(x => x).ToList();
        Assert.Equal(expectedDurations, actualDurations);
    }

    /// <summary>
    /// Test that retrieves information about minimum, maximum, and average rental duration of bicycles.
    /// </summary>
    [Fact]
    public void GetRentalDurationStatistics()
    {
        var currentDate = DateTime.Now;

        var rentalDurations = (from rental in seed.RentalContracts
                               where rental.StartTime <= currentDate
                               select (double)rental.RentalDurationHours)
                              .ToList();

        Assert.NotEmpty(rentalDurations);

        var minDuration = rentalDurations.Min();
        var maxDuration = rentalDurations.Max();
        var avgDuration = rentalDurations.Average();

        const double expectedMin = 1.0;
        const double expectedMax = 3.0;
        const double expectedAvg = 2.0;

        Assert.Equal(expectedMin, minDuration, 2);
        Assert.Equal(expectedMax, maxDuration, 2);
        Assert.Equal(expectedAvg, avgDuration, 2);
    }

    /// <summary>
    /// Test that retrieves top 5 clients by rental count.
    /// </summary>
    [Fact]
    public void GetTopClients()
    {
        var expectedCount = 5;

        var currentDate = DateTime.Now;

        var topClients = (from rental in seed.RentalContracts
                          join renter in seed.Renters on rental.RenterId equals renter.Id
                          where rental.StartTime <= currentDate
                          group renter by renter.Id into g
                          select new
                          {
                              Renter = g.First(), 
                              RentalCount = g.Count()
                          })
                          .OrderByDescending(x => x.RentalCount)
                          .Take(5)
                          .ToList();
 
        Assert.NotNull(topClients);
        Assert.Equal(expectedCount, topClients.Count);

        var expectedRenterIds = new[] { 1, 2, 3, 4, 5 };
        var actualRenterIds = topClients.Select(x => x.Renter.Id).ToList();
        Assert.Equal(expectedRenterIds, actualRenterIds);
    }
}