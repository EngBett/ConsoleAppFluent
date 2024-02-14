// See https://aka.ms/new-console-template for more information

using ConsoleAppFluent;

var student=Student
    .New("Cyril")
    .WithAge("78");

Console.WriteLine(student.Age);
