﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemTemArena 
{ 
    class Ganki : ITemTem
    {
        public float Health { get; set; }
        public float Stamina { get; set; }
        public float Damage { get; set; }
        public bool IsFainted { get; set; }
        public string Name { get; set; }
 
        public Ganki(string name, float health, float damage, float stamina)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Stamina = stamina;
        }
    
        public void LooseHealt(float damage)
        {
            Console.WriteLine("Ganki took " + damage + " and lost " + Health);
        }
        public void Recharge() 
        {
            Console.WriteLine("Ganki used Recharge");
        }
        public void Attack() 
        {
            Random attack = new Random();
            int number = attack.Next(1, 4);
            if(number == 1)
            {
                Sparks();
            }
            if(number == 2)
            {
                WindBlade();
            }
            if(number == 3)
            {
                ChainLightning();
            }
        }
        public float Sparks()
        {
            Console.WriteLine("Ganki used Sparks! It did " + Damage + " Damage!");
            return Damage * 2f;
        }
        public float WindBlade()
        {
            Console.WriteLine("Ganki used Wind Blade! It did " + Damage + " Damage!");
            return Damage * 3f;
        }
        public float ChainLightning()
        {
            Console.WriteLine("Ganki used Chain Lightning! It did " + Damage + " Damage!");
            return Damage * 5f;
        }
    }
}
