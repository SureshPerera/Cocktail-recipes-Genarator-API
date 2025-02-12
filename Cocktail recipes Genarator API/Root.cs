using System.Text.Json.Serialization;

public record Root(
    [property: JsonPropertyName("drinks")] IReadOnlyList<Drink> drinks
);
