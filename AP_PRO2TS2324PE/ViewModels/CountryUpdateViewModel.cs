using System.ComponentModel.DataAnnotations;

namespace AP_PRO2TS2324PE.ViewModels;
public class CountryUpdateViewModel
{
    [Required]
    public string Name { get; set; }
}
