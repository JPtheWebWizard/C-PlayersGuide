/*
 * ﻿Challenge 6: The Thing Namer 3000
 * Page 31 - 100XP
 */

Console.WriteLine("What kind of thing are we talking about?");
/*
 * Thing type
 */
string a = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
// Description
string b = Console.ReadLine();
// "of Doom" text
string c = "Doom"; // Should be "Doom" instead of "of Doom". This fixes the bug.
// Number 3000 as string data type
string d = "3000";
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");

/*
 * Answer this question: Aside from comments, what else could you do to make this code more understandable?
 * I would declare the variables at the top then have the ReadLine statements after. I would also
 * choose to use better variable naming to make it clearer what is going on.
 */