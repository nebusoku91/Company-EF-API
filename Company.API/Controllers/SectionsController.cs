namespace Company.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentsController : ControllerBase
{
    private readonly IDbService _db;
    public DepartmentsController(IDbService db) => _db = db;

    [HttpGet]
    public async Task<IResult> Get() =>
            await _db.HttpGetAsync<Section, SectionDTO>();

    [HttpGet("{id}")]
    public async Task<IResult> Get(int id) =>
        await _db.HttpSingleAsync<Section, SectionDTO>(id);

    [HttpPost]
    public async Task<IResult> Post([FromBody] SectionDTO department) =>
        await _db.HttpPostAsync<Section, SectionDTO>(department);

    [HttpPut("{id}")]
    public async Task<IResult> Put(int id, [FromBody] SectionDTO department) =>
        await _db.HttpPutAsync<Section, SectionDTO>(id, department);

    [HttpDelete("{id}")]
    public async Task<IResult> Delete(int id) =>
        await _db.HttpDeleteAsync<Section>(id);
}
