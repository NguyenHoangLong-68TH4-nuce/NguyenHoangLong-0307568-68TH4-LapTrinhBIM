using System;

namespace _30_10_2026
{
    public class Character
    {
        private int _health;
        public string Name { get; set; }
        public int MaxHealth { get; set; } = 100;
        public int Health
        {
            get => _health;
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else if (value > MaxHealth)
                {
                    _health = MaxHealth;
                    Console.WriteLine("Gia tri cua value: " + value);
                }
                else _health = value;
            }
        }
        public Character(string name, int health)
        {
            Name = name;
            _health = health;
        }
    }
}
