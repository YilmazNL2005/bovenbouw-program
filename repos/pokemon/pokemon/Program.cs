// See https://aka.ms/new-console-template for more information
using pokemon;

Console.WriteLine("Wat is de naam van je pokemon?");
string name = Console.ReadLine();
int hp = 100;
string type = "electric";
Console.WriteLine(name);

var mouse = new pikachu(name, hp, type);
string type2 = "fire";
var dragon = new charmander("charmander", 80 , type2  );

var pokeball1 = new pokeball(dragon);


Console.WriteLine(dragon.name + " - " + dragon.hp);

// Notities

dragon.char_sound();

bool running = true;
while(running)
{
    Console.WriteLine("Wat is de naam van je pokemon?");
    dragon.name = Console.ReadLine();
    Console.WriteLine("Hoeveel hp heeft je pokemon?");
    //dragon.hp = Console.ReadLine();
    Console.WriteLine("Wat is het type van je pokemon?");
    //for (int x = 0; x < 10; x++)
    //{
    //    dragon.char_sound();
    //}

          
}