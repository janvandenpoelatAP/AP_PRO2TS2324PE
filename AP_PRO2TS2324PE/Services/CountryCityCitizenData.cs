using AP_PRO2TS2324PE.Entities;
using AP_PRO2TS2324PE.Services;

namespace Oefening03_PersonsMVC.Services;

public class CountryCityCitizenDataInMemory : ICountryCityCitizenData
{
    static List<Country> countries;
    static List<City> cities;
    static List<Citizen> citizens;

    static CountryCityCitizenDataInMemory()
    {
        countries = new List<Country>
        {
            new Country {Code = "BE", Name = "België"},
            new Country {Code = "NL", Name = "Nederland"}
        };
        cities = new List<City>
        {
            new City {Id = 1, Name = "Brussel", CountryCode = "BE"},
            new City {Id = 2, Name = "Antwerpen", CountryCode = "BE"}
        };
        citizens = new List<Citizen>
        {
            new Citizen { Id = 1, CountryCode = "BE", CityId = 1, Number = 231456 },
            new Citizen { Id = 2, CountryCode = "NL", CityId = 1, Number = 39631 },
            new Citizen { Id = 3, CountryCode = "MA", CityId = 1, Number = 15204 }
        };
    }
    public IEnumerable<Country> CountryAll()
    {
        return countries;
    }
    public Country CountryDetail(string code)
    {
        return countries.FirstOrDefault(x => x.Code == code);
    }
    public IEnumerable<City> CityAll()
    {
        return cities;
    }
    public City CityDetail(long id)
    {
        return cities.FirstOrDefault(x => x.Id == id);
    }
    public IEnumerable<Citizen> CitizenAll()
    {
        return citizens;
    }
    public Citizen CitizenDetail(long id)
    {
        return citizens.FirstOrDefault(x => x.Id == id);
    }
}
