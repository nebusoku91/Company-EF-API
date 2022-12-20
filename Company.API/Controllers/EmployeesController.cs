namespace Company.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    private readonly IDbService _db;
    public EmployeesController(IDbService db) => _db = db;

    [HttpGet]
    public async Task<IResult> Get() =>
            await _db.HttpGetAsync<Employee, EmployeeDTO>();

    [HttpGet("{id}")]
    public async Task<IResult> Get(int id) =>
        await _db.HttpSingleAsync<Employee, EmployeeDTO>(id);

    [HttpPost]
    public async Task<IResult> Post([FromBody] EmployeeDTO employee) =>
        await _db.HttpPostAsync<Employee, EmployeeDTO>(employee);

    [HttpPut("{id}")]
    public async Task<IResult> Put(int id, [FromBody] EmployeeDTO employee) =>
        await _db.HttpPutAsync<Employee, EmployeeDTO>(id, employee);

    [HttpDelete("{id}")]
    public async Task<IResult> Delete(int id) =>
        await _db.HttpDeleteAsync<Employee>(id);
}
