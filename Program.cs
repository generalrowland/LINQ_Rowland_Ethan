// See https://aka.ms/new-console-template for more information
using LINQ_Rowland_Ethan;

Game[] games = new Game[]
{
    new Game("Cyberpunk 2077", 'M', "Shooter-Adventure"),
    new Game("Farcry 5", 'M', "First-person Shooter-Adventure"),
    new Game("Fallout: New Vegas", 'M', "First-person Shooter-Adventure"),
    new Game("Tom Clancy's: The Divsion", 'M', "action-Third-person shooter"),
    new Game("Fallout 3", 'M', "action-Role-playing"),
    new Game("Fallout 4", 'M', "action-Role-playing"),
    new Game("Rainbow Six Siege", 'M', "First-person Shooter-Adventure"),
    new Game("Red Dead Redemption 2", 'M', "action-Adventure"),
    new Game("Fallout 76", 'M', "action-role-playing"),
    new Game("Watch Dogs: legion", 'M', "action-adventure"),
    new Game("Overwatch 2", 'T', "first-person-shooter"),
};

var shortGames = from game in games
                 where game.Title.Length < 9
                 select $"Game Title: {game.Title.ToUpper()}";

foreach(var game in shortGames)
{
    Console.WriteLine(game);
}

var Cyberpunk = games.Where(game => game.Title == "Cyberpunk 2077")
                .Select(game => $"Title: {game.Title}, ESRB: {game.Esrb}, Genre: {game.Genre}");

Console.WriteLine(Cyberpunk.FirstOrDefault());

var mRated = from game in games
             where game.Esrb == 'M'
             select game.Title;

Console.WriteLine("M Rated Games:");
foreach(var game in mRated)
{
    Console.WriteLine(game);
}

var tRatedAction = from game in games
                   where game.Esrb == 'T' && game.Genre.Contains("Action")
                   select game.Title;

Console.WriteLine("T Rated Action Games:");
foreach (var game in tRatedAction)
{
    Console.WriteLine(game);
}