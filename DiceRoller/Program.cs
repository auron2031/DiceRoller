using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Die[] dice = new Die[5];

            //Create 5 die
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }

            //Print die values
            for (int i = 0; i < dice.Length; i++)
            {
                Console.WriteLine(dice[i].Value);
            }
            Console.ReadKey();
        }
    }
}
