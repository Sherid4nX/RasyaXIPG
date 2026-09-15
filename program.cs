using System;

namespace GameEncapsulationDemo
{
    class Program
    {
        
    static void Main(string[] args)
        {
        //Membuat objek karakter
            character hero = new character();


            // Mengakses atribut (perhatian acces mdifier)
            hero.characterID = "C-001";
            hero.characterName = "Arthas";
            hero.characterClass = "Warior";
            hero.health = 100;
            hero.level = 1;


            hero.Start();
            hero.TakeDamage(30);
            hero.Heal(10);



            hero.ShowStats();
            Console.ReadKey();
        }
    }
}
     