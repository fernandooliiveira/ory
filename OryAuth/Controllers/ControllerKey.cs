using System.Net;
using Microsoft.AspNetCore.Mvc;
using OryAuth.Service;

namespace OryAuth.Controllers;

[ApiController]
[Route("key")]
public class ControllerKey : Microsoft.AspNetCore.Mvc.Controller
{
    private readonly KeyCloakService _service;

    public ControllerKey(KeyCloakService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<HttpStatusCode> CreateUser()
    {
        var x = await _service.CreateUser();
        return HttpStatusCode.Created;
    }
}