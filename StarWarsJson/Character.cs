using System.Text.Json.Serialization;

public class Character
{
    [JsonPropertyName("name")]
    public string Name {get; set;}

    [JsonPropertyName("height")]
    public string Height {get; set;}

    [JsonPropertyName("mass")]
    public string Mass {get; set;}

    [JsonPropertyName("species")]
    public string Species {get; set;}

    [JsonPropertyName("homeworld")]
    public string Homeworld {get; set;}
}
