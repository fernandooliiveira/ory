using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace OryAuth.Models;

public class Email
{
    public Email(string value)
    {
        Value = value;
    }

    [JsonPropertyName("email")]
    public string Value { get; }


    // public string? Type { get; set; }
    // public string? Format { get; set; }
    // public string? Title { get; set; }
    // public int? MinLength { get; set; }
    //
    // [JsonProperty("ory.sh/kratos")]
    // public OryShKratos? Oryshkratos { get; set; }
    //
    // public abstract class OryShKratos
    // {
    //     public Cred? Credentials { get; set; }
    //     public Verify? Verification { get; set; }
    //     public Rec? Recovery { get; set; }
    //
    //     public abstract class Rec
    //     {
    //         public string? Via { get; set; }
    //     }
    //
    //     public abstract class Verify
    //     {
    //         public string? Via { get; set; }
    //     }
    //
    //     public abstract class Cred
    //     {
    //         public Passwd? Password { get; set; }
    //
    //         public abstract class Passwd
    //         {
    //             public bool? Identifier { get; set; }
    //         }
    //     }
    // }
}