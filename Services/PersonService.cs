using NishitBidOneDemo.Data;
using NishitBidOneDemo.Helpers;

namespace NishitBidOneDemo.Services;

public class PersonService : IPersonService
{
    readonly ILogger<PersonService> _logger;
    const string _personsFile = "persons.json";

    public PersonService(ILogger<PersonService> logger)
    {
        _logger = logger;
    }

    public void CreatePerson(PersonData person)
    {
        _logger.LogInformation($"[CreatePerson] Creating person {JsonHelper.Serialize(person)}");

        var persons = JsonHelper.ReadFromFile<List<PersonData>>(_personsFile);

        persons?.Add(person);

        JsonHelper.WriteToFile(_personsFile, persons);

        _logger.LogInformation("[CreatePerson] Person created");
    }
}
