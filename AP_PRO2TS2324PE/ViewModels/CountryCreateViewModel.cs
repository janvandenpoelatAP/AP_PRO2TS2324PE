using System.ComponentModel.DataAnnotations;

namespace AP_PRO2TS2324PE.ViewModels;
public class CountryCreateViewModel
{
    [Required, MaxLength(2), RegularExpression("^[A-Z]{2}$")]
    public string Code { get; set; }
    [Required]
    public string Name { get; set; }
}
