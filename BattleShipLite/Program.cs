
using System.ComponentModel;
using BattleShipLite;
using BattleShipLite.UIMethods;
using ShipLibrary.Methods;
using ShipLibrary.Models;


PlayerInfoModel player1 = new PlayerInfoModel();
PlayerInfoModel player2 = new PlayerInfoModel();
int turnCount = 1;

Console.WriteLine("Welcome to Battleship Lite!");
Console.WriteLine("Created by Patrick Shea");
Console.WriteLine("");
player1 = BuildPlayer.build("PLAYER1");

Console.WriteLine("Welcome to Battleship Lite!");
Console.WriteLine("Created by Patrick Shea");
Console.WriteLine("");
player2 = BuildPlayer.build("PLAYER2");

do
{
    PlayerInfoModel attacker;
    PlayerInfoModel defender;
    int p1Score = ScoreChecker.score(player1);
    int p2Score = ScoreChecker.score(player2);


    attacker = player1;
    defender = player2;
    Console.WriteLine($"{attacker.PlayerName}'s turn");
    Console.WriteLine($"{attacker.PlayerName}'s Attack Grid: ");
    DisplayShotGrid.DisplayGrid(attacker);
    TakeShot.ShotCoordinates(turnCount, attacker, defender);
    Console.WriteLine("**************************************************");
    p1Score = ScoreChecker.score(player1);
    p2Score = ScoreChecker.score(player2);
    if (p1Score == 5)
    {
        Console.WriteLine($"Game Over. {player1.PlayerName} wins!");
    }
    else if (p2Score == 5)
    {
        Console.WriteLine($"Game Over. {player2.PlayerName} wins!");
    }
    else
    {
        Console.WriteLine($"Score Board: {player1.PlayerName}: {p1Score} || {player2.PlayerName}: {p2Score}");
    }
    Console.WriteLine("**************************************************");


    attacker = player2;
    defender = player1;
    Console.WriteLine($"{attacker.PlayerName}'s turn");
    Console.WriteLine($"{attacker.PlayerName}'s Attack Grid: ");
    DisplayShotGrid.DisplayGrid(attacker);
    TakeShot.ShotCoordinates(turnCount, attacker, defender);

    Console.WriteLine("**************************************************");
    p1Score = ScoreChecker.score(player1);
    p2Score = ScoreChecker.score(player2);
    if (p1Score == 5)
    {
        Console.WriteLine($"Game Over. {player1.PlayerName} wins!");
        break;
    }
    else if (p2Score == 5)
    {
        Console.WriteLine($"Game Over. {player2.PlayerName} wins!");
        break;
    }
    else
    {
        Console.WriteLine($"Score Board: {player1.PlayerName}: {p1Score} || {player2.PlayerName}: {p2Score}");
    }
    Console.WriteLine("**************************************************");


    turnCount++;
} while (true);





