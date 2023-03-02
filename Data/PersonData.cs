using System.ComponentModel;

namespace NishitBidOneDemo.Data;

public class PersonData
{
    [DisplayName("First Name")]
    public string FirstName { get; set; }

    [DisplayName("Last Name")]
    public string LastName { get; set; }
}
