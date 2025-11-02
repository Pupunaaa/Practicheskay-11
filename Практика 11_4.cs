using System;

namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("", 1, 0);
            Console.Write("Введите имя игрока: ");
            string nameInput = Console.ReadLine();
            player.Name = nameInput;

            Console.Write("Введите здоровье игрока: ");
            int healthInput;
            if (int.TryParse(Console.ReadLine(), out healthInput) || healthInput <= 100 || healthInput >= 0)
            {
                player.Health = healthInput;
            }
            else
            {
                Console.WriteLine("Некорректный ввод здоровья, установлено значение 1.");
                player.Health = 1;
            }

            Console.Write("Введите уровень игрока: ");
            int levelInput;
            if (int.TryParse(Console.ReadLine(), out levelInput) || levelInput <= 100 || levelInput >= 0)
            {
                player.Level = levelInput;
            }
            else
            {
                Console.WriteLine("Некорректный ввод уровня игрока, установлено значение 1.");
                player.Level = 1;
            }
            player.UpdateIsLong();
            player.Info();
            player.TakeDamage(10);
            player.Info();
        }
    }

    class Player
    {
        private string name;
        private int health;
        private int level;
        private bool islong;

        public Player(string PlayerName, int PlayerHealth, int PlayerLevel)
        {
            name = PlayerName;
            health = PlayerHealth;
            level = PlayerLevel;
            UpdateIsLong();
        }
        public string Name
        {
            set
            {
                name = value;
            }
            get
            {
                return name;
            }
        }

        public int Level 
        {
            set 
            {
                level = value;
            }
            get
            {
                return level;
            }
        }
        public int Health
        {
            set
            {
                health = value;
                UpdateIsLong();
            }
            get
            {
                return health;
            }
        }

        public bool IsLong
        {
            get
            {
                return islong;
            }
        }
        public void UpdateIsLong()
        {
            islong = health >= 1;
        }

        public void TakeDamage(int damage) 
        {
            if (damage >= 0)
            {
                Health -= Math.Min(damage, Health);
            }
        }
        public void Info()
        {
            Console.WriteLine($"Игрок: {name}, уровень: {level}, здоровье: {health}, Жив: {islong}");
        }
    }
}