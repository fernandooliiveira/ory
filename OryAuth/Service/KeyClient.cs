using Keycloak.AuthServices.Sdk.Admin;
using Keycloak.AuthServices.Sdk.Admin.Models;
using Keycloak.AuthServices.Sdk.Admin.Requests.Users;

namespace OryAuth.Service;

public abstract class KeyClient : IKeycloakUserClient
{
    public Task<IEnumerable<User>> GetUsers(string realm, GetUsersRequestParameters? parameters = null)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetUser(string realm, string userId)
    {
        throw new NotImplementedException();
    }

    public Task<HttpResponseMessage> CreateUser(string realm, User user)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUser(string realm, string userId, User user)
    {
        throw new NotImplementedException();
    }

    public Task SendVerifyEmail(string realm, string userId, string? clientId = null, string? redirectUri = null)
    {
        throw new NotImplementedException();
    }
}