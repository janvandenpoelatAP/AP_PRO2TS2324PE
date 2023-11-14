using System.ComponentModel.DataAnnotations;

namespace AP_PRO2TS2324PE.ViewModels;
public class CityUpdateViewModel
{
    [Required]
    public string Name { get; set; }
    [Required, MaxLength(2), RegularExpression("^[A-Z]{2}$")]
    public string CountryCode { get; set; }
}
