using System;

namespace Enemies
{
    /// <summary> public class zombie</summary>
    class Zombie
    {
        public int health;
        /// public constructor.
        public Zombie()
        {
            health = 0;
        }

        /// <summary> field health</summary>
        string name = default "(No name)";
        public string name;{
            get => name;
            set => name = value;
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