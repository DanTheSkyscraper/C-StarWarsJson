using RestSharp;
using System.IO;
using System.Text.Json;

RestClient client = new("https://swapi.py4e.com/api/");

string starWarsCharacter = "Anakin Skywalker";
RestRequest requestChar = new($"character/{starWarsCharacter}");
RestResponse responseChar = client.GetAsync(requestChar).Result;


string starWarsPlanet = "tatooine";
RestRequest requestPlanet = new($"planet/{starWarsPlanet}");
RestResponse responsePlanet = client.GetAsync(requestPlanet).Result;