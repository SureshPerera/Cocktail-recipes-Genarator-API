using System.Text.Json;

var baseAddress = "https://www.thecocktaildb.com/api/json/v1/1/";
var requistUri = "search.php?s=margarita";
Console.WriteLine("\tCocktail recipes Genarator..! (API = Cocktail Database)");
Console.WriteLine("Waiting for loading....\n");
IApiDataReader apiDataReader = new ApiDataReader();
var json =await apiDataReader.Read(baseAddress, requistUri);
var root = JsonSerializer.Deserialize<Root>(json);
var count = 0;

foreach (var item in root.drinks)
{
    Console.WriteLine($"{count+1}.Drink Name :{item.strDrink},\nCatogory :{item.strCategory},\nAlcohole :{item.strAlcoholic},\nIntroductions :{item.strInstructionsDE},\nIngredient : {item.strIngredient1},{item.strIngredient2},{item.strIngredient3},{item.strIngredient4},{item.strIngredient5},{item.strIngredient6}");
    Console.WriteLine();
    count++;
}
Console.ReadLine();
