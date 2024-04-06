/*
 * 
 * Level 7 ﻿Challenge 10: The Four Sisters and the Duckbear
 * Page 56 - 100XP
 * 
Four sisters own a chocolate farm and collect chocolate eggs laid by chocolate chickens every day. But
more often than not, the number of eggs is not evenly divisible among the sisters, and everybody knows
you cannot split a chocolate egg into pieces without ruining it. The arguments have grown more heated
over time. The town is tired of hearing the four sisters complain, and Chandra, the town’s Arbiter, has
finally come up with a plan everybody can agree to. All four sisters get an equal number of chocolate
eggs every day, and the remainder is fed to their pet duckbear. All that is left is to have some skilled
Programmer build a program to tell them how much each sister and the duckbear should get.

Objectives:
• Create a program that lets the user enter the number of chocolate eggs gathered that day.
• Using / and %, compute how many eggs each sister should get and how many are left over for the
duckbear.
• Answer this question: What are three total egg counts where the duckbear gets more than each
sister does? You can use the program you created to help you find the answer
*/

int eggsCollected, fourSisters, duckbear;

Console.Write("Enter how many eggs were collected: ");
eggsCollected = Convert.ToInt32(Console.ReadLine());
fourSisters = eggsCollected / 4;
duckbear = eggsCollected % 4;

Console.WriteLine($"Each sister gets {fourSisters} eggs");
Console.WriteLine("Eggs for duckbear: " + duckbear);

/* Answer this question: What are three total egg counts where the duckbear gets more than each sister does?
 Use the program you created to help you find the answer.

 If there is less than four eggs, the sisters will get 0. So a total count of 1, 2, or 3 would each
 give the duckbear more than the sisters. But 6 will give each sister 1 and the duckbear 2, 7 gives
 each sister 1 and the duckbear 3, and 11 gives each sister 2 and the duckbear 3.*/