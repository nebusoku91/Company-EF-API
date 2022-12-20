namespace Company.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ACompanysController : ControllerBase
{

    private readonly IDbService _db;
    public ACompanysController(IDbService db) => _db = db;

    [HttpGet]
    public async Task<IResult> Get() =>
       await _db.HttpGetAsync<ACompany, ACompanyDTO>();

    [HttpGet("{id}")]
    public async Task<IResult> Get(int id) =>
    await _db.HttpSingleAsync<ACompany, ACompanyDTO>(id);

    [HttpPost]
    public async Task<IResult> Post([FromBody] ACompanyDTO company) =>
        await _db.HttpPostAsync<ACompany, ACompanyDTO>(company);

    [HttpPut("{id}")]
    public async Task<IResult> Put(int id, [FromBody] ACompanyDTO company) =>
        await _db.HttpPutAsync<ACompany, ACompanyDTO>(id, company);

    [HttpDelete("{id}")]
    public async Task<IResult> Delete(int id) =>
        await _db.HttpDeleteAsync<ACompany>(id);
}
