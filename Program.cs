// See https://aka.ms/new-console-template for more information
using System.Text.Json;
using game1402_a2_starter;

Console.WriteLine("Welcome to VII V I :).\n");
Console.Write("Maahin's Text Adventure Game.\n\n");
string fileName = "../../../game_data.json";//if you are ever worried about whether your json is valid or not, check out JSON Lint: 

GameData yourGameData;
string jsonString = File.ReadAllText(@fileName);
yourGameData = JsonSerializer.Deserialize<GameData>(jsonString);
Game yourGame = new Game(yourGameData);
while (true)
{
    Console.WriteLine(yourGame.CurrentRoom.thePath);
   
    Console.Write("What will you do? > ");
    yourGame.ProcessString(Console.ReadLine());

    //if (yourGame.IsDone)
    //{
    //    return;
    //}
}
