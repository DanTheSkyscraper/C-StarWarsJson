using System.Text.Json.Serialization;

namespace StarWarsJson;

public class Planet
{
    [JsonPropertyName("name")]
    public string Name {get; set;}

    [JsonPropertyName("climate")]
    public string Climate {get; set;}

    [JsonPropertyName("terrain")]
    public string Terrain {get; set;}

    [JsonPropertyName("population")]
    public string Population {get; set;}
}
