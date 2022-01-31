
using System.ComponentModel;
using BattleShipLite;
using ShipLibrary.Methods;
using ShipLibrary.Models;

Console.WriteLine("Welcome to Battleship Lite!");

PlayerInfoModel player1 = new PlayerInfoModel();
PlayerInfoModel player2 = new PlayerInfoModel();

player1.PlayerName = ConsoleMessage.MessageAndResponseString("Enter Player1's name. ");


ShipGridBuilder.BuildGrid(player1);

player2.PlayerName = ConsoleMessage.MessageAndResponseString("Enter Player2's name. ");


ShipGridBuilder.BuildGrid(player2);