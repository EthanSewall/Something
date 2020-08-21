using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientation
{
    class Enemy
    {
        public float health = 50;
        public float strength = 11;

        public void TakeDamage(float damagePoints)
        {
            health -= damagePoints;
            Console.WriteLine($"Enemy recieves {damagePoints} damage.");
        }

        public bool IsDefeated
        {
            get
            {
                if (health > 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
