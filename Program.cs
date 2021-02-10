using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //three basic arrays
            // int[] array;
            // array = new int[] {0,1,2,3,4,5,6,7,8,9};
            // Console.WriteLine(array[0]);

            string[] nameArray;
            nameArray = new string[] {"Tim", "Martin", "Nikki", "Sara"};
            // Console.WriteLine(nameArray[0]);

            bool[] lengthArray = {true,false,true,false,true,false,true,false,true,false,};
            // Console.WriteLine(lengthArray[5]);

            //List of Flavors
            List<string> flavors = new List<string>();
            flavors.Add("cherry");
            flavors.Add("vanilla");
            flavors.Add("chocolate");
            flavors.Add("mint");
            flavors.Add("oreos");
            flavors.Add("rainbow");
            // Console.WriteLine(flavors.Count);
            // Console.WriteLine(flavors[2]);
            // flavors.Remove(flavors[2]);
            // Console.WriteLine(flavors.Count);
            
            //User Info Dictionary
            Dictionary<string,string> profiles = new Dictionary<string,string>();

                Random rand = new Random();
                for(int i = 0; i < nameArray.Length; i++)
                {
                    profiles.Add(nameArray[i], flavors[rand.Next(0, flavors.Count)]);
                }

                foreach (var entry in profiles){
                // foreach (KeyValuePair<string,string> entry in profile){ same results
                    Console.WriteLine(entry.Key + "-" + entry.Value);
                }


        }
    }
}
