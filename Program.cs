using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithSentances
{
    internal class FunWith Sentances
    {
        static void Main()
        {
            string noun, verb, adjective, adverb;
           

            Console.WriteLine("Enter a noun: ");
            noun = Console.ReadLine();

            Console.WriteLine("Enter a verb: ");
            verb = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            adjective = Console.ReadLine();

            Console.WriteLine("Enter an adverb: ");
            adverb = Console.ReadLine();

            Console.WriteLine($"The {adjective} {noun} {adverb} {verb} across the room.");
            Console.ReadLine();



        //UnitConverter

        float centimeters, inches;
        Console.WriteLine("Enter centimeters: ");
        centimeters = float.Parse(Console.ReadLine());

        inches = centimeters * 0.3937f; //Conversion factor

        Console.WriteLine($"{centimeters} cm is equal to {inches:F2} inches");

        }
    }
}
