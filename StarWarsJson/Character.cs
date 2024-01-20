using System.Text.Json.Serialization;

public class Character
{
    [JsonPropertyName("name")]
    public string Name {get; set;}

    [JsonPropertyName("height")]
    public string Id {get; set;}

    [JsonPropertyName("mass")]
    public string Mass {get; set;}

    [JsonPropertyName("homeworld")]
    public string Homeworld {get; set;}
}
