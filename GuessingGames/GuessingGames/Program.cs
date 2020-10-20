using System;
using System.Collections.Generic;
using System.Threading;

namespace MyGame
{
    public class GussingGame
    {
        public static int GuessMe { get; protected set; }
        //if this field is not static, you have no way to check its value without creating objects, also it will be hard for you to share this value among different players.
        public static Random R { get; private set; }
        //making static random object will help you to generate unbiased uniform randoms across all players 
        public static int Steps { get; private set; }
        //count total play turns for all players
        public static int LOW { get; private set; }
        //lowest value of the game  
        public static int HIGH { get; private set; }
        //highest value of the game
        public static int TotalPlayers { get; private set; }
        // count new players as they are added
        public string PlayerName { get; private set; }
        //you can read player name, but can not change it from main function
        //player name is object dependent non-static field
        public int IndividualAttempt { get; private set; }
        //total individual attempt is also object dependent non-static field
        static GussingGame()  //initialize all static variables using a static constructor
        {
            R = new Random();
            Steps = 0;
            LOW = 0;
            HIGH = 50; //change this value to change the number range
            TotalPlayers = 0;
            GuessMe = R.Next(LOW, HIGH);
        }

        public GussingGame(string name)
        {
            //player specific constructor method
            //initialize all non-static fields using one-parameter public constructor where 
            //set player name, and initialize individual's attempt. 
            //Also, update total players count (static field). 
            //To Do
            PlayerName = name;
            IndividualAttempt = 0;
            TotalPlayers++;

        }
        public static int CheckWin(int currentGuess)
        {
            // static method common method for all players
            //ToDo
            //return 0 for correct guess, 1 if actual value is bigger, -1 Otherwise.
            if (GuessMe == currentGuess) return 0;
            else if (GuessMe > currentGuess) return 1;
            else return -1;
         
        }
        public static void GiveHints(int guess)
        {
            //common hints for all players (static method)

            //ToDo
            //give some hints: text-output example: guess bigger or guess samller
            //May use CheckWin method.

            if (CheckWin(guess) == 1)
            Console.WriteLine("Guess Higher");
            else if (CheckWin(guess) == -1)
                Console.WriteLine("Guess Lower");
           
        }
        public static int WhoesTurn()
        {
            //shared field for all players (static method)

            //ToDo
            //determine whose turn and return playerID number

            return Steps % TotalPlayers+1;

        }
        public static int GetWinningPlayerID()
        {
            //shared filed for all players (static method)

            //ToDo
            //a player just won at the previous step, i.e. step-1

            return (Steps-1) % TotalPlayers+1;

        }
        public string GetPlayerName()
        {
            //Object dependent non-static method

            //ToDo
            //return player name

            return PlayerName;
        }

        public int Play()
        {
            string input;
            //object dependent non static method

            //ToDo
            //update total steps (static shared data)
            
            Steps++;

            //write a message like playerName please enter your guess...

            Console.WriteLine("Please enter your guess {0}:", PlayerName);

            //input from user
            input=Console.ReadLine ();

            //update player dependent individual attempt
            IndividualAttempt++;
            //return the int number

            return int.Parse(input);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            string playerName;
            List<GussingGame> players = new List<GussingGame>();  //list of objects
            do  //adding players
            {
                Console.WriteLine("Please enter a player name: ");
                playerName = Console.ReadLine();
                GussingGame newPlayer = new GussingGame(playerName); //add a player
                players.Add(newPlayer);          //add list of player objects
                Console.WriteLine("Another player? :Y/N ");
                choice = Console.ReadLine();
            } while (choice == "y" || choice == "Y");

            //Console.WriteLine("Assume You dont Know The Number: " + GussingGame.guessMe); //this is secret (shared) number, players will guess
            //Thread.Sleep(1000);
            int currentGuess;
            do
            {
                Console.Clear();
                Console.WriteLine("Guess a number in range {0} to {1}: ", GussingGame.LOW, GussingGame.HIGH); //accessing through class
                Console.WriteLine("Now playing player: {0}", GussingGame.WhoesTurn()); //accessing class to determine who will play
                currentGuess = players[GussingGame.WhoesTurn() - 1].Play();    //right object will respond by sharing game world
                GussingGame.GiveHints(currentGuess);  //accessing through class, shared message for all objects
                Thread.Sleep(1000);
            } while (GussingGame.CheckWin(currentGuess) != 0); //common/shared message

            Console.WriteLine("Congratulations! Player {0}: {1} Wins...", GussingGame.GetWinningPlayerID(), players[GussingGame.GetWinningPlayerID() - 1].GetPlayerName());
            Console.WriteLine("Total attempt for Player {0}: {1} was {2}.", GussingGame.GetWinningPlayerID(), players[GussingGame.GetWinningPlayerID() - 1].GetPlayerName(), players[GussingGame.GetWinningPlayerID() - 1].IndividualAttempt);
            Console.WriteLine("Total attempt counted for all players was {0}.", GussingGame.Steps); //accessing through class field which is shared by all objects
            Console.ReadKey();
        }
    }
}