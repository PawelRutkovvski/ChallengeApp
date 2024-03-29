﻿using ChallengeApp;

Console.WriteLine("Welcome To Employee Evaluation Program");
Console.WriteLine("======================================");
Console.WriteLine();

var employee = new EmployeeInFile("Paweł", "Rutkowski");
employee.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender,EventArgs args)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Dodano nową ocenę");
    Console.ResetColor();  
}

while (true)
{
    Console.WriteLine("Enter next grade of Your Employee: ");
    Console.WriteLine("... or q to see statistics");

    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
var statistics = employee.GetStatistics();
Console.WriteLine();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"AverageLetter {statistics.AverageLetter}");