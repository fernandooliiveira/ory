using Keycloak.AuthServices.Sdk.Admin;
using Keycloak.AuthServices.Sdk.Admin.Models;
using Microsoft.VisualBasic;

namespace OryAuth.Service;

public class KeyCloakService
{
    private readonly IKeycloakUserClient _service;
    
    public KeyCloakService(IKeycloakUserClient service)
    {
        _service = service;
    }
    
    public async Task<object> CreateUser()
    {
        var user = await _service.CreateUser("bankrit", new User
        {
            Email = "fernando.oliveira@zetti.tech",
            EmailVerified = true,
            RealmRoles = new[] { "client" },
            FirstName = "Fernando",
            LastName = "Oliveira",
            Username = "fernando.olveira"
        });
        Console.WriteLine(user);
        return "";
    }
}