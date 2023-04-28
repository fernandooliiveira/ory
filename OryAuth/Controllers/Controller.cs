using System.Net;
using Microsoft.AspNetCore.Mvc;
using Ory.Kratos.Client.Model;
using OryAuth.Service;

namespace OryAuth.Controllers;

[ApiController]
[Route("auth")]
public class Controller : Microsoft.AspNetCore.Mvc.Controller
{
    private readonly IdentityService _service;

    public Controller(IdentityService service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<IActionResult> MethodTest(string email)
    {
        var identity = await _service.CreateIdentity(email);
        if (identity != null)
        {
            return Created("", identity);
        }
        return BadRequest("Erro");
    }

    [HttpGet]
    public async Task<string> CreateSession()
    {
        var response = await _service.CreateSession();
        return "ok";
    }




}