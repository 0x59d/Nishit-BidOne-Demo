using NishitBidOneDemo.Data;
using NishitBidOneDemo.Helpers;

namespace NishitBidOneDemo.Services;

public class PersonService : IPersonService
{
    const string _personsFile = "persons.json";

    public void CreatePerson(PersonData person)
    {
        var persons = JsonHelper.ReadFromFile<List<PersonData>>(_personsFile);

        persons?.Add(person);

        JsonHelper.WriteToFile(_personsFile, persons);
    }
}
