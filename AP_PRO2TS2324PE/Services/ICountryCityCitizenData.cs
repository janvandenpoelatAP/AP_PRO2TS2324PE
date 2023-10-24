using AP_PRO2TS2324PE.Entities;

namespace AP_PRO2TS2324PE.Services;

public interface ICountryCityCitizenData
{
    IEnumerable<Country> CountryAll();
    Country CountryDetail(string code);
    IEnumerable<City> CityAll();
    City CityDetail(long id);
    IEnumerable<Citizen> CitizenAll();
    Citizen CitizenDetail(long id);
}
