using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientation
{
    class Player
    {
        public float healthPoints = 100;
        public float strength = 12;

        public void TakeDamage(float damagePoints)
        {
            healthPoints -= damagePoints;
            Console.WriteLine($"Player recieves {damagePoints} damage.");
        }

        public bool IsDefeated
        {
            get
            {
                if (healthPoints > 0)
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
