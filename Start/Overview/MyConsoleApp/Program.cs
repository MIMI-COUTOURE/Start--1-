﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string response;
Console.WriteLine("What is Your name ");
response = Console.ReadLine();
Console.WriteLine($"Enjoy the Course, {response}");

OperatingSystem thisOS = Environment.OSVersion;
Console.WriteLine(thisOS.Platform);
Console.WriteLine(thisOS.VersionString);

