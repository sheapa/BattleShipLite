
using System.ComponentModel;
using BattleShipLite;
using ShipLibrary.Methods;
using ShipLibrary.Models;

Console.WriteLine("Welcome to Battleship Lite!");

PlayerInfoModel player1 = new PlayerInfoModel();
PlayerInfoModel player2 = new PlayerInfoModel();

player1.PlayerName = ConsoleMessage.MessageAndResponseName("Enter Player1's name. ");


ShipGridBuilder.BuildGrid(player1, 0);

player2.PlayerName = ConsoleMessage.MessageAndResponseName("Enter Player2's name. ");


ShipGridBuilder.BuildGrid(player2, 0);