using Company.API.Extensions;

namespace Company.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PositionsController : ControllerBase
{
    private readonly IDbService _db;
    public PositionsController(IDbService db) => _db = db;

    [HttpGet]
    public async Task<IResult> Get() =>
            await _db.HttpGetAsync<Position, PositionDTO>();

    [HttpGet("{id}")]
    public async Task<IResult> Get(int id) =>
        await _db.HttpSingleAsync<Position, PositionDTO>(id);

    [HttpPost]
    public async Task<IResult> Post([FromBody] PositionDTO position) =>
        await _db.HttpPostAsync<Position, PositionDTO>(position);

    [HttpPut("{id}")]
    public async Task<IResult> Put(int id, [FromBody] PositionDTO position) =>
        await _db.HttpPutAsync<Position, PositionDTO>(id, position);

    [HttpDelete("{id}")]
    public async Task<IResult> Delete(int id) =>
        await _db.HttpDeleteAsync<Position>(id);
}