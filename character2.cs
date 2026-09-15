using System;
namespace GameEncapsulationDemo
{
    public class character
    {
        public string characterID;
        protected string characterName;
        internal string characterClass;
        private float health;
        private int level;

        public character()
        {
            characterID = "UNKNOWN";
            characterName = "Hero";
            characterClass = "Adventure";
            health =100;
            level = 1;
            Console.WriteLine("Objek Character dibuat dengan konstruktor Default.");
        }

        public character(string id, string name)
        {
            characterID = id;
            characterName = name;
            characterClass = "Adventure";
            health =100;
            level = 1;
            Console.WriteLine($"Objek Character dibuat dengan konstruktor Berparameter (ID & Name).");
        }

        public character(string id, string name, string classType)
        {
            characterID = id;
            characterName = name;
            characterClass = classType;
            health =100;
            level = 1;
            Console.WriteLine($"Objek Character dibuat dengan konstruktor Berparameter(ID, Name, Class).");
        }

        public void Star()
        {
            level = 1;
            health;
            Console.WriteLine($"karakter {characterName} (level1 {level})memulai petualangan");
        }

        private void levelup()
        {
            level++;
            Console.WriteLine($"{characterName} naik level! level sekarang: {level}");
        }

        public void TakeDamage(float dmg)
        {
            health -= dmg;
            Console.WriteLine($"{characterName} menerima {dmg} damage. Health tersisa:{health}");
            if (health <= 0)
            {
                Console.WriteLine($"{characterName} telah gugur!");
            }
        }
        public void Heal(float healmet)
        {
            health += healAmt;
             Console.WriteLine($"{characterName} sembuh sebesar {healAmt}. Health sekarang: {health}");
        }

        public void Showstats()
        {
            Console.WriteLine("===STAS KARAKTER ===");
            Console.WriteLine($"ID     : {characterID}");
            Console.WriteLine($"Nama     : {characterName}");
            Console.WriteLine($"Class     : {characterClass}");
            Console.WriteLine($"Level     : {level}");
            Console.WriteLine($"Health     : {health}");
            Console.WriteLine("=======================");
        }
    }
}
 






