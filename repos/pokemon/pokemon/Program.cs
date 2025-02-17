// See https://aka.ms/new-console-template for more information
using pokemon;

Console.WriteLine("Hello, World!");

Console.WriteLine("Hello, World!");
string antwoord = Console.ReadLine();
string name = "pikachu";
int hp = 150;
string type = "fire";
Console.WriteLine(name);

var pikachu1 = new pikachu(name, hp , type  );
pikachu1.name = "charmander";
pikachu1.hp = 30;
pikachu1.type = "fire";


var pokeball1 = new pokeball(type, );


Console.WriteLine(pikachu1.name + " - " + pikachu1.hp);

// Notities

pikachu1.geeftles();

bool running = true;
while(running)
{
    Console.WriteLine("Wat is de naam van je pokemon?");
    pikachu1.name = Console.ReadLine();
    Console.WriteLine("Hoeveel hp heeft je pokemon?");
    //pikachu1.hp = Console.ReadLine();
    Console.WriteLine("Wat is het type van je pokemon?");
    for (int x = 0; x < 10; x++)
    {
        pikachu1.geeftles();
    }

          
}