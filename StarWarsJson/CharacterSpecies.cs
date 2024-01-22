using System.Text.Json.Serialization;

public class CharacterSpecies
{
    [JsonPropertyName("name")]
    public string Name {get; set;}
}
