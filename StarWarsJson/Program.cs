using RestSharp;
using StarWarsJson;
using System.IO;
using System.Text.Json;

RestClient client = new("https://swapi.py4e.com/api/");

string starWarsCharacter = "anakin skywalker";
RestRequest requestChar = new($"character/{starWarsCharacter}");
RestResponse responseChar = client.GetAsync(requestChar).Result;


string starWarsPlanet = "tatooine";
RestRequest requestPlanet = new($"planet/{starWarsPlanet}");
RestResponse responsePlanet = client.GetAsync(requestPlanet).Result;

Character a = JsonSerializer.Deserialize<Character>(responseChar.Content);
Planet b = JsonSerializer.Deserialize<Planet>(responsePlanet.Content);

Console.WriteLine(a.Name);
Console.WriteLine(a.Species);
Console.WriteLine(a.Height);
Console.WriteLine(a.Mass);
Console.WriteLine(a.Homeworld);

Console.WriteLine("\n\n");

Console.WriteLine(b.Name);
Console.WriteLine(b.Terrain);
Console.WriteLine(b.Climate);
Console.WriteLine(b.Population);


Console.ReadLine();