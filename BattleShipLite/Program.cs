
using System.ComponentModel;
using BattleShipLite;
using BattleShipLite.UIMethods;
using ShipLibrary.Methods;
using ShipLibrary.Models;

Console.WriteLine("Welcome to Battleship Lite!");
Console.WriteLine("Created by Patrick Shea");
Console.WriteLine("");

PlayerInfoModel player1 = new PlayerInfoModel();
PlayerInfoModel player2 = new PlayerInfoModel();
int turnCount = 1;

player1 = BuildPlayer.build("PLAYER1");

player2 = BuildPlayer.build("PLAYER2");

do
{
    PlayerInfoModel attacker;
    PlayerInfoModel defender;


    attacker = player1;
    defender = player2;
    Console.WriteLine($"{attacker.PlayerName}'s turn");
    Console.WriteLine("Attack Grid: ");
    DisplayShotGrid.DisplayGrid(player1);
    TakeShot.ShotCoordinates(turnCount, attacker, defender);
    


    attacker = player2;
    defender = player1;
    Console.WriteLine($"{attacker.PlayerName}'s turn");
    Console.WriteLine("Attack Grid: ");
    DisplayShotGrid.DisplayGrid(player1);
    TakeShot.ShotCoordinates(turnCount, attacker, defender);
    


    turnCount++;
} while (true);





