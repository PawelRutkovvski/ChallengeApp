using ChallengeApp;
using System;

var employee = new Employee("Pawel", "CoMaWszystko");
employee.AddScore(3);
employee.AddScore(4);
employee.AddScore(5);

var statistics = employee.GetStatistics();
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Average: {statistics.Average}");