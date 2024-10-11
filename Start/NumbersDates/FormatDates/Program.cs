// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for formatting date information
using System.Globalization;

// Define a date
DateTime AprFool = new DateTime(2025, 4, 1, 13, 23, 30);

// TODO: 'd' Short date: mm/dd/yyyy (or dd/mm depending on locale)
Console.WriteLine($"{AprFool:d}");

// TODO: 'D' Full date: mm/dd/yyyy (or dd/mm depending on locale)
Console.WriteLine($"{AprFool:D}");

// TODO: 'f' Full date, short time
Console.WriteLine($"{AprFool:f}");

// TODO: 'F' Full date, long time
Console.WriteLine($"{AprFool:F}");

// TODO: 'g' General date and time
Console.WriteLine($"{AprFool:g}");

// TODO: 'G' General date and time
Console.WriteLine($"{AprFool:G}");

// TODO: Format using a specific CultureInfo
Console.WriteLine(AprFool.ToString("d", CultureInfo.CreateSpecificCulture("de-DE")));

// TODO: Defining custom date and time formats
Console.WriteLine($"{AprFool:dddd, MMMM, d yyyy}");
Console.WriteLine($"{AprFool:ddd, h:mm:ss tt}");
Console.WriteLine($"{AprFool:MMM, d yyyy}");