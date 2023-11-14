using System.ComponentModel.DataAnnotations;

namespace AP_PRO2TS2324PE.ViewModels;
public class CitizenCreateViewModel
{
    [Required, MaxLength(2), RegularExpression("^[A-Z]{2}$")]
    public string CountryCode { get; set; }
    public long Number { get; set; }
    [Required]
    public long CityId { get; set; }
}
