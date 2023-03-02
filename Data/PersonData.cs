using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NishitBidOneDemo.Data;

public class PersonData
{
    [Required]
    [DisplayName("First Name")]
    public string FirstName { get; set; }
    
    [Required]
    [DisplayName("Last Name")]
    public string LastName { get; set; }
}
