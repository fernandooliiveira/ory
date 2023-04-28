using System.Text.Json;
using Ory.Kratos.Client.Api;
using Ory.Kratos.Client.Client;
using Ory.Kratos.Client.Model;
using OryAuth.Models;

namespace OryAuth.Service;

public class IdentityService
{
    private readonly IdentityApi _api;
    private readonly FrontendApi _frontendApi;

    public IdentityService()
    {
        _frontendApi = new FrontendApi(
            new Configuration
            {
                BasePath = "http://127.0.0.1:4455"
            }
        );
        _api = new IdentityApi(
            new Configuration
            {
                BasePath = "http://127.0.0.1:4434"
            }
        );
    }


    public async Task<KratosIdentity?> CreateIdentity(string email)
    {
        var trait = new Traits(email);
        var body =
            new KratosCreateIdentityBody(
                null,
                null,
                null,
                null,
                "default",
                KratosIdentityState.Active,
                trait
            );
        try
        {
            var result = await _api.CreateIdentityAsync(body);
            return result;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public async Task<KratosSession?> CreateSession()
    {
        var x = await _frontendApi.CreateNativeLoginFlowWithHttpInfoAsync(true);
        Console.WriteLine(x);
        return null;
    }
}