// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using game1402_a2_starter;

Console.WriteLine("Hello, World!");
string fileName = "../../../game_data.json";//if you are ever worried about whether your json is valid or not, check out JSON Lint: 

GameData yourGameData;
string jsonString = File.ReadAllText(@fileName);
yourGameData = JsonSerializer.Deserialize<GameData>(jsonString);
Game yourGame = new Game(yourGameData);
while (true)
{
    Console.WriteLine(yourGameData.Rooms[0].thePath);
   
    Console.Write("What will you do? > ");
    Console.WriteLine(yourGameData.Rooms[0].thePath + "\n");
    Console.WriteLine(yourGameData.Rooms[1].thePath + "\n");
    Console.WriteLine(yourGameData.Rooms[2].thePath + "\n");
    yourGame.ProcessString(Console.ReadLine());
    return 0;
}
