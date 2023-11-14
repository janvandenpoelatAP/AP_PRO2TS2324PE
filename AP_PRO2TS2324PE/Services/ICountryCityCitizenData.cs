using AP_PRO2TS2324PE.Entities;

namespace AP_PRO2TS2324PE.Services;

public interface ICountryCityCitizenData
{
    IEnumerable<Country> CountryAll();
    Country CountryDetail(string code);
    void AddCountry(Country country);
    void DeleteCountry(Country country);
    void UpdateCountry(Country country);
    IEnumerable<City> CityAll();
    City CityDetail(long id);
    void AddCity(City city);
    void DeleteCity(City city);
    void UpdateCity(City city);
    IEnumerable<Citizen> CitizenAll();
    Citizen CitizenDetail(long id);
    void AddCitizen(Citizen citizen);
    void DeleteCitizen(Citizen citizen);
    void UpdateCitizen(Citizen citizen);
}
