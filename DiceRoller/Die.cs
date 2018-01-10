using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    /// <summary>
    /// Represents a standard single 6-sided dice
    /// </summary>
    class Die
    {
        private static Random random;
        /// <summary>
        /// Creates a die with a random value
        /// </summary>
        public Die()
        {
            random = new Random();
            Roll();
        }

        public byte Value { get; private set; }
        /// <summary>
        /// Rolls the die and generates a new 7
        /// </summary>
        public void Roll()
        {
            //Generate a new random value
            Random rand = new Random();
            int val = rand.Next(1, 7);
            Value = Convert.ToByte(val);
        }
    }
}
