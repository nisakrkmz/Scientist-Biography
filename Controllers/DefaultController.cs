using Microsoft.AspNetCore.Mvc;
using NetCoreProject_1.Models;

namespace NetCoreProject_1.Controllers;
public class DefaultController : Controller
{
    private readonly OpenAiService _openAiService;

    public DefaultController(OpenAiService openAiService)
    {
        _openAiService = openAiService;
    }


    [HttpGet]
    public IActionResult CreateInformation()
    {
        return View(); 
    }

    [HttpPost]
    public async Task<IActionResult> CreateInformation(string scientistName)
    {
        if (string.IsNullOrEmpty(scientistName))
        {
            ViewBag.scientistLife = "Please provide a scientist's name.";
            return View();
        }

        var result = await _openAiService.GetScientistLifeAsync(scientistName);
        ViewBag.scientistLife = result;
        return View();
    }
}





