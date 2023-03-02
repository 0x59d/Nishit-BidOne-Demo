using Microsoft.AspNetCore.Mvc;
using NishitBidOneDemo.Data;
using NishitBidOneDemo.Models;
using NishitBidOneDemo.Services;
using System.Diagnostics;

namespace NishitBidOneDemo.Controllers;

public class PersonController : Controller
{
    private readonly ILogger<PersonController> _logger;
    private readonly IPersonService _personService;

    public PersonController(
        IPersonService personService,
        ILogger<PersonController> logger)
    {
        _personService = personService;
        _logger = logger;
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(PersonData person)
    {
        if (!ModelState.IsValid)
            return View("Create", person);

        _personService.CreatePerson(person);

        ModelState.Clear();

        ViewBag.Success = true;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}