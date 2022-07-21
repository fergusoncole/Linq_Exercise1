using System.Linq;

var videogames = new List<string>() { "Batman Arkham Asylum", "Batman Arkham City", "Batman Arkham Origins", "Batman Arkham Knight", " God of War Ragnarok" };
videogames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));