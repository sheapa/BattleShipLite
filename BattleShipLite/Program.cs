
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

player1 = BuildPlayer.build("PLAYER1");


DisplayShotGrid.DisplayGrid(player1);
int turnCount = 1;
do
{
    Console.WriteLine("Player1's turn");
    TakeShot.ShotCoordinates(turnCount, player1, player2);

    turnCount++;
} while (true);

player2 = BuildPlayer.build("PLAYER2");



