using System;

namespace Enemies
{
    /// <summary> public class zombie</summary>
    class Zombie
    {
        /// <summary> field health</summary>
        private int health;
        /// default name No name
        private string name = default "(No name)";
        /// <summary>public constructor.<summary/>
        public Zombie()
        {
            health = 0;
        }
        /// Public <summary>Name getter sette <summary/>
        public string Name;
        {
            get
            {
                return name;
            }
            set
            {
                name=value;
            }
        }
        /// <summary>Zombie <summary/>
        public Zombie(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
        p
        /// <summary>Health method<summary/>
        public int GetHealth()
        {
            return health;
        }
    }
}