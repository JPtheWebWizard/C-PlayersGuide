/*
* Level 7 ﻿Challenge 9: The Triangle Farmer
* Page 52 - 100XP
* ------------------------------------------------------------------------------------------------------------------------------------------------------------------
* As you pass through the fields near Arithmetica City, you encounter P-Thag, a triangle farmer, scratching numbers in the dirt.
* 
* "What is all of that writing for?" You ask.
* 
* "I'm just trying to calculate the area of all of my triangles. They sell by their size. The bigger they are, the more they are worth! But I have many triangles on
* my farm, and the math gets tricky, and I sometimes make mistakes. Taking a tiny triangle to town thinking you're going to get 100 gold, only to be told it's only
* worth three, is not fun! If only I had a program that could help me..." Suddenly, P-Thag looks at you with fresh eyes. "Wait just a moment. You have the look of
* a programmer about you. Can you help me write a program that will compute the areas for me, so I can quit worrying about math mistakes and get back to tending
* my triangles? The equation i'm using is this one here," he says, pointing to the formula, etched in a stone beside him:
* 
*           Area = (1/2) *  (base * height)
*           
* Objectives...
* 1. Write a program that lets you input the triangle's base size and height.
* 2. Compute the area of a triangle by turning the above equation into code.
* 3. Write the result of the computation.
*/

// My Solution

double triArea, triBase, triHeight;

Console.Write("Enter the base: ");
triBase = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the height: ");
triHeight = Convert.ToDouble(Console.ReadLine());

triArea = (1.0 / 2.0) * (triBase * triHeight);

Console.WriteLine("Area: " + triArea);

/*
 * the expression 1/2 represents integer division because both 1 and 2 are integers. In integer division, the result is truncated,
 * meaning any fractional part is discarded. So 1/2 evaluates to 0, not 0.5 as you might expect.
 * This is why I chose to represent 1/2 as 1.0/2.0. By using 1.0/2.0, you're ensuring that the division is performed with floating-point
 * numbers. When you have at least one floating-point operand in an arithmetic operation, the result will also be a floating-point number.
 * So 1.0/2.0 evaluates to 0.5 as you would expect for the calculation of the area of a triangle.
 */

/* Books Solution

Console.WriteLine("What is the triangle's width?");
string widthText = Console.ReadLine();
float width = Convert.ToSingle(widthText);

Console.WriteLine("What is the triangle's height?");
string heightText = Console.ReadLine();         
float height = Convert.ToSingle(heightText);

float area = (width * height) / 2;                  You don't need floating number 2.0 here bc the numerator (width*height) is floating.
Console.WriteLine("The area is " + area);

*/