using System;

namespace Enemies
{
    /// <summary> public class zombie</summary>
    class Zombie
    {
        private int health;
        /// default name No name
        private string name = default "(No name)";
        /// public constructor.
        public Zombie()
        {
            health = 0;
        }

        /// <summary> field health</summary>
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
        /// Zombie 
        public Zombie(int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
        }
        p
        /// Health method
        public int GetHealth()
        {
            return health;
        }
    }
}