var names = new[] { "Nick", "John", "Mike", "Peter" };
var serialized = JsonSerializer.Serialize(names);
Console.WriteLine(serialized);

// lambda improvements
var helloWord = () => "Hello Word";
var text = string? () => null;

Console.WriteLine(helloWord());
Console.ReadKey();