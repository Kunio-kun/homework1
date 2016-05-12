using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMenu();
            Console.ReadLine();
        }

        private static void RunMenu()
        {
            
        }
        //devil dz
        private static void RoboTian()
        {

        }

        //Liosha dz
        private static void PlayGame()
	{Random generator = new Random();
	
    int numberhuyamber = generator.Next(1, 101);
    int guess =-1;
 
    Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is, sick bastard?");
	
    while (guess != numberhuyamber);
    {
 
        if (guess < numberhuyamber);
        {
            Console.WriteLine("No, sick bastard, higher ");
 
        }
        if (guess > numberhuyamber);
        {
            Console.WriteLine("No, sick bastard, lower  ");
            
        }
        if (guess == numberhuyamber)
    
        {
        Console.WriteLine("Well done, sick bastard. ");
        Console.ReadLine();
        }
	}
}

        

        //Marta dz
        private static void PlayWithBools()
        {
            
        }

        //Topa dz
        private static void SortArray()
        {
            
        }
    }
}
