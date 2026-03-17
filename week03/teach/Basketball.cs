/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Basketball
{
    public static void ProcessBasketballData(string filePath)
    {
        Dictionary<string, int> playerPoints = new Dictionary<string, int>();

        foreach (var line in File.ReadLines(filePath))
        {
            var parts = line.Split(',');

            string playerId = parts[0];
            int points = int.Parse(parts[8]);

            // Si no existe, inicializar
            if (!playerPoints.ContainsKey(playerId))
            {
                playerPoints[playerId] = 0;
            }

            // Sumar puntos
            playerPoints[playerId] += points;
        }

        // Ordenar de mayor a menor
        var topPlayers = playerPoints
            .OrderByDescending(p => p.Value)
            .Take(10);

        // Mostrar resultado
        foreach (var player in topPlayers)
        {
            Console.WriteLine($"Player: {player.Key}, Points: {player.Value}");
        }
    }
}