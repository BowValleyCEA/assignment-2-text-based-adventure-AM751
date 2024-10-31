﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace game1402_a2_starter
{
    public class GameData
    {
        public string GameName { get; set; } //This is an example of a property; for whatever reason your serializable data objects will need to be written this way
        public string Description { get; set; }
        public List<Room> Rooms { get; set; } //this is only an example. You do not ha
    }

    public class Game(GameData data)
    {
        private GameData _gameData = data;
        private Room _currentRoom = data.Rooms[0];
        //public bool IsDone;

        public Room CurrentRoom
        {
            get
            {
                return _currentRoom;
            }
        }

        public void ProcessString(string enteredString)
        {
            enteredString =
                enteredString.Trim()
                    .ToLower(); //trim any white space from the beginning or end of string and convert to lower case

            string[]
                commands = enteredString
                    .Split(" "); //split based on spaces. The length of this array will tell you whether you have 1, 2, 3, 4, or more commands.
                                 //modify these functions however you want, but this is where the beginning of calling functions to handle where you are


            if (commands[0] == "go")
            {
                if (commands.Length < 2)
                {
                    Console.WriteLine("Where should you go?");
                    return;
                }

                string? roomToGoTo = null;

                switch (commands[1].ToLower())
                {
                    default:
                        Console.WriteLine($"{commands[1]} is not a place you can go to.");
                        break;
                    case "straight":
                        //_currentRoom = _gameData.Rooms.Find((Room room) => { return room.Reference == _currentRoom.Straight; });
                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == _currentRoom.Straight)
                            {
                                roomToGoTo = _currentRoom.Straight;
                            }
                        }

                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == roomToGoTo)
                            {
                                _currentRoom = room;
                            }
                        }
                        break;
                    case "back":
                        //_currentRoom = _gameData.Rooms.Find((Room room) => { return room.Reference == _currentRoom.Straight; });
                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == _currentRoom.Back)
                            {
                                roomToGoTo = _currentRoom.Back;
                            }
                        }

                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == roomToGoTo)
                            {
                                _currentRoom = room;
                            }
                        }
                        break;
                    case "left":
                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == _currentRoom.Left)
                            {
                                roomToGoTo = _currentRoom.Back;
                            }
                        }

                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == roomToGoTo)
                            {
                                _currentRoom = room;
                            }
                        }
                        break;
                    case "right":
                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == _currentRoom.Right)
                            {
                                roomToGoTo = _currentRoom.Right;
                            }
                        }

                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == roomToGoTo)
                            {
                                _currentRoom = room;
                            }
                        }
                        break;
                }
            }
            //2:
            else if (commands[0] == "eat")
            {
                if (commands.Length < 2)
                {
                    Console.WriteLine("Is that a food?");
                    return;
                }

                string? roomToGoTo = null;

                switch (commands[1].ToLower())
                {
                    default:
                        Console.WriteLine($"{commands[2]} is not a place you can go to.");
                        break;
                    case "straight":
                        //_currentRoom = _gameData.Rooms.Find((Room room) => { return room.Reference == _currentRoom.Straight; });
                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == _currentRoom.Straight)
                            {
                                roomToGoTo = _currentRoom.Straight;
                            }
                        }

                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == roomToGoTo)
                            {
                                _currentRoom = room;
                            }
                        }
                        break;
                    case "back":
                        //_currentRoom = _gameData.Rooms.Find((Room room) => { return room.Reference == _currentRoom.Straight; });
                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == _currentRoom.Back)
                            {
                                roomToGoTo = _currentRoom.Back;
                            }
                        }

                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == roomToGoTo)
                            {
                                _currentRoom = room;
                            }
                        }
                        break;
                    case "left":
                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == _currentRoom.Left)
                            {
                                roomToGoTo = _currentRoom.Back;
                            }
                        }

                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == roomToGoTo)
                            {
                                _currentRoom = room;
                            }
                        }
                        break;
                    case "right":
                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == _currentRoom.Right)
                            {
                                roomToGoTo = _currentRoom.Right;
                            }
                        }

                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == roomToGoTo)
                            {
                                _currentRoom = room;
                            }
                        }
                        break;

                }
            }
            //3:
            else if (commands[0] == "cook")
            {
                if (commands.Length < 2)
                {
                    Console.WriteLine("some meat and vegetables.");
                    return;
                }

                string? roomToGoTo = null;

                switch (commands[1].ToLower())
                {
                    default:
                        Console.WriteLine($"{commands[2]} is not a place you can go to.");
                        break;
                    case "straight":
                        //_currentRoom = _gameData.Rooms.Find((Room room) => { return room.Reference == _currentRoom.Straight; });
                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == _currentRoom.Straight)
                            {
                                roomToGoTo = _currentRoom.Straight;
                            }
                        }

                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == roomToGoTo)
                            {
                                _currentRoom = room;
                            }
                        }
                        break;
                    case "back":
                        //_currentRoom = _gameData.Rooms.Find((Room room) => { return room.Reference == _currentRoom.Straight; });
                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == _currentRoom.Back)
                            {
                                roomToGoTo = _currentRoom.Back;
                            }
                        }

                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == roomToGoTo)
                            {
                                _currentRoom = room;
                            }
                        }
                        break;
                    case "left":
                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == _currentRoom.Left)
                            {
                                roomToGoTo = _currentRoom.Back;
                            }
                        }

                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == roomToGoTo)
                            {
                                _currentRoom = room;
                            }
                        }
                        break;
                    case "right":
                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == _currentRoom.Right)
                            {
                                roomToGoTo = _currentRoom.Right;
                            }
                        }

                        foreach (var room in _gameData.Rooms)
                        {
                            if (room.Reference == roomToGoTo)
                            {
                                _currentRoom = room;
                            }
                        }
                        break;
                        
                         

                }

            }
            else if (commands[0] == "i" && commands[1] == "should" && commands[2] == "escape") //1.
            {
                Console.WriteLine("you need to find a lead to find a way out of the house but, beofre that you need some food intake since you are starving.\n");
            }

            else if (commands[0] == "i" && commands[1] == "will" && commands[2] == "cook") //2.
            {
                Console.WriteLine("You might get useful things from store room\n");
            }

            else if (commands[0] == "this" && commands[1] == "helps" && commands[2] == "cooking") //3.
            {
                Console.WriteLine("You might cook a delicious meal with this.\n");
            }

            else if (commands[0] == "i" && commands[1] == "know" && commands[2] == "nothing")
            {
                Console.WriteLine("i'll help you.\n");
            }
            else
            {
                Console.WriteLine("I didn't understand you.\n");
               
            }

            //string
            //response =
            //"Default response"; //you will always do something when processing the string and then give a response
            //Console.WriteLine(response); //what you tell the person after what they entered has been processed
        }

    }

}
