using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shotGunStories
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] shot = new string[] { "pas de tir", "tir avec main droite", "tir avec main gauche", "tir avec PistoLaserXFire" };
            int[] dice = new int[] { 1,1,1,0,0,0,2,2,2,3 };
         
            int number = new Random().Next(1,11);

            Console.WriteLine(shot[ dice[number-1] ]);
        }
    }
}
