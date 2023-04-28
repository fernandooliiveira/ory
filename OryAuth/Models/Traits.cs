using System.Text.Json.Serialization;

namespace OryAuth.Models;

public class Traits
{
    public Traits(string value)
    {
        Email = value;
    }

    [JsonPropertyName("email")]
    public string Email { get; }
    
}