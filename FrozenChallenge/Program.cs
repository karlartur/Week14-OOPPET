using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace FrozenChallenge
{
    class Program
    {
        class Wish
        {
            string name;
            string wants;
            string number;

            public Wish(string _name, string _wants, string _number)
            {
                name = _name;
                wants = _wants;
                number = _number;
            }

            public string Name
            {
                get { return name; }
            }
            public string Wants
            {
                get { return wants; }
            }
            public string Number
            {
                get { return number; }
            }
        }
        static void Main(string[] args)
        {
            List<string> wishListFromFile = getWishesFromFile().ToList();
            List<Wish> listOfWishes = new List<Wish>();

            foreach (string wishRecord in wishListFromFile)
            {
                string[] tempArray = wishRecord.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Wish newMovie = new Wish(tempArray[0], tempArray[1], tempArray[2]);


                listOfWishes.Add(newMovie);
            }
            foreach (Wish Wish in listOfWishes)
            {
                Console.WriteLine($"{Wish.Name} Wants {Wish.Wants} for christmas");
                Console.WriteLine($"total price {Wish.Number}");
            }

        }
        public static string[] getWishesFromFile()
        {
            string filePath = $@"C:\users\opilane\Samples\Frozen.txt";
            string[] dataFromFiles = File.ReadAllLines(filePath);
            return dataFromFiles;

        }
        public static void ShowDataFromArray(string[] someArray)
        {
            foreach (string line in someArray)
            {
                Console.WriteLine(line);
            }
        }
    }
}
