// See https://aka.ms/new-console-template for more information
using otusPrototype;

var person = new Person
{
    Name = "Иван",
};
Console.WriteLine("orinal: " + person.Name);
var clone = person.Clone();
Console.WriteLine("clone: " + clone.Name);
Console.WriteLine();
Console.WriteLine();
var manager = new Manager
{
    Name= "Petr",
    Salary = "20000",
    TestWords = "Manaer1"
};
Console.WriteLine("orinal: " + manager.Name + " "+manager.Salary + " " + manager.TestWords);
var clon2 = manager.Clone();
Console.WriteLine("clone: " + clon2.Name + " " + clon2.Salary + " " + clon2.TestWords);

Console.WriteLine();
Console.WriteLine();

var director = new Director
{
    Name = "Andreuy",
    Salary = "120000",
    TestWords = "Dir1",
};
Console.WriteLine("orinal: " + director.Name + " " + director.Salary + " " + director.TestWords);
var clon3 = director.Clone();
Console.WriteLine("clone: " + director.Name + " " + director.Salary + " " + director.TestWords);
Console.WriteLine();
Console.WriteLine();