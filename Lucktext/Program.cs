using System;

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;

Console.WriteLine("Driving test");
Console.WriteLine();
Console.WriteLine("Enter ONE word for each category:");
Console.WriteLine();

Console.WriteLine("Ajective #1:");
string adjective1 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Adjective #2:");
string adjective2 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Adjective #3:");
string adjective3 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Adverb:");
string adverb = Console.ReadLine();
Console.Clear();

Console.WriteLine("Noun #1:");
string noun1 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Noun #2:");
string noun2 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Noun #3:");
string noun3 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Noun #4:");
string noun4 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Noun #5:");
string noun5 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Noun #6:");
string noun6 = Console.ReadLine();
Console.Clear();

Console.WriteLine("Plural noun:");
string pluralNoun = Console.ReadLine();
Console.Clear();

Console.WriteLine("Driving Test");
Console.WriteLine();
Console.WriteLine($"Driving a car can be fun if you follow this {adjective1} advice: ");
Console.WriteLine($"When approaching a {noun1} on the right, always blow your {noun2}.");
Console.WriteLine($"Before making an {adjective2} turn, always stick your {noun3} out of the window.");
Console.WriteLine($"Every 2000 miles, have your {noun4} inspected and your {noun5} checked.");
Console.WriteLine($"When approaching a school, watch out for {adjective3} {pluralNoun}");
Console.WriteLine($"Above all, drive {adverb}. The {noun6} you save may be your own!");

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Press enter to exit.");
Console.ReadLine();