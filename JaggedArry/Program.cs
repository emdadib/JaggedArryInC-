using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArry
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] person = new string[3];
            person[0] = "Shamim";
            person[1] = "Emdad";
            person[2] = "Pulak";

            string[][] arrys = new string[3][];
            arrys[0] = new string[3];
            arrys[1] = new string[1];
            arrys[2] = new string[2];

            arrys[0][0] = "BSC";
            arrys[0][1] = "MSc";
            arrys[0][2] = "PhD";

            arrys[1][0] = "BSC";

            arrys[2][0] = "BSC";
            arrys[2][1] = "MSc";

            for(int i = 0; i< arrys.Length; i++)
            {
                string[] innerArry = arrys[i];
                Console.WriteLine(person[i]);
                Console.WriteLine("---------");
                for(int j = 0; j<innerArry.Length; j++)
                { 
                    Console.WriteLine(innerArry[j]);
                }
                
            }







            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
           
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
