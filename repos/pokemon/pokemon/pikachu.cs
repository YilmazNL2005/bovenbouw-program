using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon
{
    public class pikachu // Blauwdruk
    {
        public string name { get; set; }
        public int hp { get; set; }
        public string type { get; set; }
        public pikachu(string name, int hp, string type)
        {
            this.name = name;
            this.hp = hp;
            this.type = type;
        }


        public void geeftles()
        {
            Console.WriteLine(this.name);
            Console.WriteLine("Blah Blah Blah...");
        }

    }

    public class charmander
    {
        public string name { get; set; }
        public int hp { get; set; }
        public string type { get; set; }
        public charmander(string name, int hp, string type) // Constructor
        {
            this.name = name;
            this.hp = hp;
            this.type = type;
        }

        public void char_sound()
        {
            Console.WriteLine(this.name);
            Console.WriteLine("Rawr Rawr Rawr...");
        }

    }

    public class green_pokemon
    {
        public string name { get; set; }
        public int hp { get; set; }
        public string type { get; set; }
        public green_pokemon (string name, int hp, string type) // Constructor
        {
            this.name = name;
            this.hp = hp;
            this.type = type;
        }

        public void bul_sound()
        {
            Console.WriteLine(this.name);
            Console.WriteLine("Bulba Bulba Saur!!!");
        }

    }

    public class trainer
    {
        public string name { get; set; }
        public List<pokeball> belt;

        public trainer(string name)
        {
            this.name = name;
        }

        public void MaakMaarPokeballenAanEnKoppelDezeAanDeBelt(charmander c)
        {
            this.belt.Add(new pokeball(c));
        }

        public void trainer_sound()
        {
            Console.WriteLine(this.name);
            Console.WriteLine("Rawr Rawr Rawr...");
        }

    }

    public class pokeball
    {
        public charmander content { get; set; }
        public pokeball(charmander pokemon)
        {
            this.content = pokemon;
        }

    }
}

//    public class pokeball
//{
//    public string type { get; set; }
//    public int level { get; set; }
//    public pikachu
//    public charmander(string name, int hp, string type)
//    {
//        this.name = name;
//        this.hp = hp;
//        this.type = type;
//    }
//}