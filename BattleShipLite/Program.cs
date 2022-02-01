
using System.ComponentModel;
using BattleShipLite;
using BattleShipLite.UIMethods;
using ShipLibrary.Methods;
using ShipLibrary.Models;

Console.WriteLine("Welcome to Battleship Lite!");
Console.WriteLine("Created by Patrick Shea");

PlayerInfoModel player1 = new PlayerInfoModel();
PlayerInfoModel player2 = new PlayerInfoModel();

player1 = BuildPlayer.build("player1");

player2 = BuildPlayer.build("player2");


