using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pangram = "The quick brown fox jumps over the lazy dog";
            // reverse each word in a message
            // OUTPUT ==> ehT kciuq nworb xof spmuj revo eht yzal god

            // splits each word in pangram string to comma separated individual/separate elements
            // string[] items = {"The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog"};
            string[] items = pangram.Split(' ');
            foreach(string item in items)
            {
                //Console.Write(item+ " ");
                char[] itemArray = item.ToCharArray();
                Array.Reverse(itemArray); // reverses each word
                string itemString = new string(itemArray); //converting back to string to print without iterating char array
                Console.Write(itemString + " ");
            }

            Console.ReadLine();
        }
    }
}
