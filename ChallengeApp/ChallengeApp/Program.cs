using ChallengeApp;
using System;

var employee = new Employee("Pawel", "CoMaWszystko");
employee.AddScore(5);
employee.AddScore(8);
employee.AddScore(5);
employee.AddScore(8);

var statistics1 = employee.GetStatisticsWithFor();
var statistics2 = employee.GetStatisticsWithForEach();
var statistics3 = employee.GetStatisticsWithWhile();
var statistics4 = employee.GetStatisticsWithDoWhile();

Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Average: {statistics1.Average}");
Console.WriteLine(" ");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Average: {statistics2.Average}");
Console.WriteLine(" ");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Average: {statistics3.Average}");
Console.WriteLine(" ");
Console.WriteLine($"Max: {statistics4.Max}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Average: {statistics4.Average}");