using BikeRentalPoint.Api.Host.Grpc;
using Microsoft.AspNetCore.Mvc;


namespace BikeRentalPoint.Api.Host.Controllers;

/// <summary>
/// API controller that exposes an endpoint for triggering generation of sample bike rental data via gRPC.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class GenerationController(GrpcClientConsumer grpcConsumer) : ControllerBase
{
    private readonly GrpcClientConsumer _grpcConsumer = grpcConsumer;

    /// <summary>
    /// Starts the test data generation process by calling the gRPC generation service.
    /// </summary>
    /// <param name="totalCount">Total number of records of each entity type to generate.</param>
    /// <param name="batchSize">Batch size, i.e. number of entities of each type returned in a single response.</param>
    /// <returns>HTTP 200 response when the generation process has been successfully started.</returns>
    [HttpPost("start")]
    public async Task<IActionResult> StartGeneration([FromQuery] int totalCount, [FromQuery] int batchSize)
    {
        await _grpcConsumer.StartGenerationAsync(totalCount, batchSize);
        return Ok(new { Message = "Generation completed" });
    }
}
