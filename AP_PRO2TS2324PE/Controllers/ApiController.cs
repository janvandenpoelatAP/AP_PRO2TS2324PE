using Microsoft.AspNetCore.Mvc;
using AP_PRO2TS2324PE.Entities;
using AP_PRO2TS2324PE.Services;

namespace AP_PRO2TS2324PE.Controllers;

[Route("[controller]/[action]")]
public class ApiController : Controller
{
    private readonly ICountryCityCitizenData countryCityCitizenData;

    public ApiController(ICountryCityCitizenData countryCityCitizenData)
    {
        this.countryCityCitizenData = countryCityCitizenData;
    }
    [HttpGet]
    public IActionResult Countries()
    {
        return Ok(countryCityCitizenData.CountryAll());
    }
    [HttpGet("{code}")]
    public IActionResult Countries(string code)
    {
        Country country = countryCityCitizenData.CountryDetail(code);
        return Ok(country);
    }
    [HttpGet]
    public IActionResult Cities()
    {
        return Ok(countryCityCitizenData.CountryAll());
    }
    [HttpGet("{id}")]
    public IActionResult Cities(long id)
    {
        City city = countryCityCitizenData.CityDetail(id);
        return Ok(city);
    }
    [HttpGet]
    public IActionResult Citizens()
    {
        return Ok(countryCityCitizenData.CitizenAll());
    }
    [HttpGet("{id}")]
    public IActionResult Citizens(long id)
    {
        Citizen citizen = countryCityCitizenData.CitizenDetail(id);
        return Ok(citizen);
    }
}