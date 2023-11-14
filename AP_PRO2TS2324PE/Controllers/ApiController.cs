using Microsoft.AspNetCore.Mvc;
using AP_PRO2TS2324PE.Entities;
using AP_PRO2TS2324PE.Services;
using AP_PRO2TS2324PE.ViewModels;

namespace AP_PRO2TS2324PE.Controllers;

[Route("[controller]")]
public class ApiController : Controller
{
    private readonly ICountryCityCitizenData countryCityCitizenData;

    public ApiController(ICountryCityCitizenData countryCityCitizenData)
    {
        this.countryCityCitizenData = countryCityCitizenData;
    }
    [Route("Countries")]
    [HttpGet]
    public IActionResult ReadCountries()
    {
        return Ok(countryCityCitizenData.CountryAll());
    }
    [Route("Countries/{code}")]
    [HttpGet]
    public IActionResult ReadCountry(string code)
    {
        Country country = countryCityCitizenData.CountryDetail(code);
        return Ok(country);
    }
    [Route("Countries")]
    [HttpPost]
    public IActionResult CreateCountry([FromBody] CountryCreateViewModel countryCreateViewModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        Country country = new Country()
        {
            Code = countryCreateViewModel.Code,
            Name = countryCreateViewModel.Name
        };
        countryCityCitizenData.AddCountry(country);
        return CreatedAtAction(nameof(CreateCountry), country);
    }
    [Route("Countries/{code}")]
    [HttpDelete]
    public IActionResult DeleteCountry(string code)
    {
        Country countryDb = countryCityCitizenData.CountryDetail(code);
        if (countryDb is null)
        {
            return NotFound();
        }
        countryCityCitizenData.DeleteCountry(countryDb);
        return NoContent(); 
    }
    [Route("Countries/{code}")]
    [HttpPut]
    public IActionResult UpdateCountry(string code, [FromBody] CountryUpdateViewModel countryUpdateViewModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        Country countryDb = countryCityCitizenData.CountryDetail(code);
        if (countryDb is null)
        {
            return NotFound();
        }
        Country country = new Country()
        {
            Code = code,
            Name = countryUpdateViewModel.Name
        };
        countryCityCitizenData.UpdateCountry(country);
        return Ok(country);
    }
    [Route("Cities")]
    [HttpGet]
    public IActionResult Cities()
    {
        return Ok(countryCityCitizenData.CountryAll());
    }
    [Route("Cities/{id}")]
    [HttpGet]
    public IActionResult Cities(long id)
    {
        City city = countryCityCitizenData.CityDetail(id);
        return Ok(city);
    }
    [Route("Cities")]
    [HttpPost]
    public IActionResult CreateCity([FromBody] CityCreateViewModel cityCreateViewModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        City city = new City()
        {
            Name = cityCreateViewModel.Name,
            CountryCode = cityCreateViewModel.CountryCode,
        };
        countryCityCitizenData.AddCity(city);
        return CreatedAtAction(nameof(CreateCity), city);
    }
    [Route("Cities/{id}")]
    [HttpDelete]
    public IActionResult DeleteCity(int id)
    {
        City cityDb = countryCityCitizenData.CityDetail(id);
        if (cityDb is null)
        {
            return NotFound();
        }
        countryCityCitizenData.DeleteCity(cityDb);
        return NoContent();
    }
    [Route("Cities/{id}")]
    [HttpPut]
    public IActionResult UpdateCity(int id, [FromBody] CityUpdateViewModel cityUpdateViewModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        City cityDb = countryCityCitizenData.CityDetail(id);
        if (cityDb is null)
        {
            return NotFound();
        }
        City city = new City()
        {
            Id = id,
            Name = cityUpdateViewModel.Name,
            CountryCode = cityUpdateViewModel.CountryCode,
        };
        countryCityCitizenData.UpdateCity(city);
        return Ok(city);
    }
    [Route("Citizens")]
    [HttpGet]
    public IActionResult Citizens()
    {
        return Ok(countryCityCitizenData.CitizenAll());
    }
    [Route("Citizens/{id}")]
    [HttpGet]
    public IActionResult Citizens(long id)
    {
        Citizen citizen = countryCityCitizenData.CitizenDetail(id);
        return Ok(citizen);
    }
    [Route("Citizens")]
    [HttpPost]
    public IActionResult CreateCitizen([FromBody] CitizenCreateViewModel citizenCreateViewModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        Citizen citizen = new Citizen()
        {
            CountryCode = citizenCreateViewModel.CountryCode,
            Number = citizenCreateViewModel.Number,
            CityId = citizenCreateViewModel.CityId
        };
        countryCityCitizenData.AddCitizen(citizen);
        return CreatedAtAction(nameof(CreateCitizen), citizen);
    }
    [Route("Citizens/{id}")]
    [HttpDelete]
    public IActionResult DeleteCitizen(long id)
    {
        Citizen citizenDb = countryCityCitizenData.CitizenDetail(id);
        if (citizenDb is null)
        {
            return NotFound();
        }
        countryCityCitizenData.DeleteCitizen(citizenDb);
        return NoContent();
    }
    [Route("Citizens/{id}")]
    [HttpPut]
    public IActionResult UpdateCitizen(long id, [FromBody] CitizenUpdateViewModel citizenUpdateViewModel)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        Citizen citizenDb = countryCityCitizenData.CitizenDetail(id);
        if (citizenDb is null)
        {
            return NotFound();
        }
        Citizen citizen = new Citizen()
        {
            Id = id,
            CountryCode = citizenUpdateViewModel.CountryCode,
            Number = citizenUpdateViewModel.Number,
            CityId = citizenUpdateViewModel.CityId
        };
        countryCityCitizenData.UpdateCitizen(citizen);
        return Ok(citizen);
    }
}