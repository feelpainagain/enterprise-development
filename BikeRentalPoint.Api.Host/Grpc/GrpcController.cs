using Microsoft.AspNetCore.Mvc;

namespace BikeRentalPoint.Api.Host.Grpc;

/// <summary>
/// Контроллер для запуска процесса генерации тестовых данных аренды велосипедов.
/// </summary>
[ApiController]
[Route("api/[controller]")]
public class GenerationController : ControllerBase
{
    private readonly GrpcClientConsumer _grpcConsumer;

    /// <summary>
    /// Инициализирует новый экземпляр контроллера генерации с gRPC‑клиентом‑консумером.
    /// </summary>
    /// <param name="grpcConsumer">Сервис, вызывающий gRPC‑генератор и сохраняющий данные в БД.</param>
    public GenerationController(GrpcClientConsumer grpcConsumer)
    {
        _grpcConsumer = grpcConsumer;
    }

    /// <summary>
    /// Точка входа для запуска генерации тестовых данных через gRPC‑сервис.
    /// </summary>
    /// <param name="totalCount">Общее количество записей каждого типа, которые нужно сгенерировать.</param>
    /// <param name="batchSize">Размер батча, то есть количество сущностей каждого типа в одном ответе.</param>
    [HttpPost("start")]
    public async Task<IActionResult> StartGeneration([FromQuery] int totalCount, [FromQuery] int batchSize)
    {
        await _grpcConsumer.StartGenerationAsync(totalCount, batchSize);
        return Ok(new { Message = "Generation started" });
    }
}
