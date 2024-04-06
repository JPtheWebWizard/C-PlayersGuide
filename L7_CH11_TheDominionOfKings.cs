/*
* 
* Level 7 ﻿Challenge 11: The Dominion of Kings
* Page 57 - 100XP
* 
Three kings, Melik, Casik, and Balik, are sitting around a table, debating who has the greatest kingdom
among them. Each king rules an assortment of provinces, duchies, and estates. Collectively, they agree
to a point system that helps them judge whose kingdom is greatest: Every estate is worth 1 point, every
duchy is worth 3 points, and every province is worth 6 points. They just need a program that will allow
them to enter their current holdings and compute a point total.

Objectives:
• Create a program that allows users to enter how many provinces, duchies, and estates they have.
• Add up the user’s total score, giving 1 point per estate, 3 per duchy, and 6 per province.
• Display the point total to the user.
*/

int estateNum, duchyNum, provinceNum, totalScore;

Console.Write("Please enter how many estates you own: ");
estateNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter how many duchies you own: ");
duchyNum = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter how many provinces you own: ");
provinceNum = Convert.ToInt32(Console.ReadLine());

totalScore = (estateNum * 1) + (duchyNum * 3) + (provinceNum * 6);

Console.WriteLine($"Total score: {totalScore}");