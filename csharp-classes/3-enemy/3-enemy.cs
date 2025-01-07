﻿using System;

namespace Enemies
{
    /// <summary> public class zombie</summary>
    class Zombie
    {
        /// <summary> field health</summary>
        public int health;
        /// public constructor.
        public Zombie()
        {
            this.health = 0;
        }
        /// Zombie 
        public Zombie(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }
        /// Health method
        public int getHealth()
        {
            return this.health;
        }
    }
}