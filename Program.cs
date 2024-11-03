// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Net.Quic;
using System.Text.Json;
using System.Windows.Input;
using game1402_a2_starter;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(" Welcome to:\n" +
    " NAVIGATION- The TEXT BASED GAME\n");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Write(" Ahamed's Text based Adventure Game.\n\n");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(" Maahin got kidnapped and kept in a Room with bare amount of light source.\n Help him to find a way all out of an unknown house and accomplish the OBJECTIVE.\n");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine(" THE TASK: You have to NAVIGATE Maahin through Certain areas inside the home and help him to find a way out of the house.\n\n " +
    "INSTRUCTION: You can Navigate MAAHIN by giving inputs through COMPASS DIRECTIONS. That is, starting with the word 'go' and has to follow through with the Directions accordingly.\n" +
    " IMPORTANT NOTE: EVERY LETTERS HAS TO BE IN LOWER CASE, to proceed further.\n");


string fileName = "../../../game_data.json";//if you are ever worried about whether your json is valid or not, check out JSON Lint: 


GameData yourGameData;
string jsonString = File.ReadAllText(@fileName);
yourGameData = JsonSerializer.Deserialize<GameData>(jsonString);
Game yourGame = new Game(yourGameData);

Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(" Press ENTER key to proceed further:\n");
Console.ReadLine();

Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine("\nIf you are clueless, type 'help' and tap the ENTER key for a short description on how you can Proceed further.\n");
Console.WriteLine("* After the first description of the current room do type 'help' if you are clueless.\n " +
                    "* If you are on the Living Room, you have to head towards the Dining Room\n" +
                    "* If you are on the Dining Room, you have to find a way yourself to the next room to get something which will help you to get out of your starving.\n" +
                    "* If you have something to eat after cooking for yourself, then you are ready for the next task.\n" +
                    "* If you manage to find the way out of the house, you are very near to complete your objective.\n" +
                    " Now the game is all yours go ahead.");
Console.ReadLine();

while (true)
{
 
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine(yourGame.CurrentRoom.thePath);
    Console.WriteLine("\nWhat will you do?");
    

    yourGame.ProcessString(Console.ReadLine());

    //After reaching the final room, the game will end.
    Console.BackgroundColor = ConsoleColor.DarkGreen;
    if (yourGame.CurrentRoom.IsExit)
    {
        Console.WriteLine("MAAHIN successfully ESCAPES with the help of your NAVIGATION.\n\n");
        Console.WriteLine("Hooray... You've done it.... You are a Great Explorer.\n\n");
        Console.WriteLine("CREDITS:\n" +
            "Concept and Development: AHAMED MAAHIN.\n\n");
        Console.WriteLine("NOTE: More rooms to be added in Upcomming days.\n\n");
        Console.WriteLine("Thanks for playing the game and hope you liked it.\n" +
            "Your feedbacks are welcome and appreciated :)");
        break;
    }

    

}


