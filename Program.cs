// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Net.Quic;
using System.Text.Json;
using System.Windows.Input;
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
    Console.WriteLine("Press ENTER key to proceed further:\n");
    Console.ReadLine();

    Console.WriteLine("\nAny Assistance?..");
    Console.WriteLine("\nIf you are clueless, type 'help' and tap the ENTER key for a short description on how you can Proceed further.\n" +
        "After the first description of the current room do type 'help' if you are clueless.");
    Console.ReadLine();

    Console.WriteLine(yourGame.CurrentRoom.thePath);
    Console.Write("\nWhat will you do?");

    yourGame.ProcessString(Console.ReadLine());

    
    


}
