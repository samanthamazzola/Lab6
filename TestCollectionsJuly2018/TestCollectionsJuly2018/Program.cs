using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCollectionsJuly2018
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<string> studentNames = new List<string>();

            //methods (Add method) to start building chain of links of a list
            studentNames.Add("Jesse"); //first link of chain
            studentNames.Add("Chris"); //second link of chain
            studentNames.Add("Zac"); // link of chain
            studentNames.Add("Ash"); // link of chain

            //remove
            studentNames.Remove("Zac"); // remove using item name //removes "zac" from the link chain and continues the connection
            studentNames.RemoveAt(0); // remove by index 


            //insert
            studentNames.Insert(1, "Kristen"); // insert at index 1 
            // will have Kristen take 1 index place and move everyone else down


            // for arrays searching the index you use .Length for list you use .Count
            for (int i = 0; i < studentNames.Count; i++)
            {
                Console.WriteLine(studentNames[i]);
            }
            foreach (string name in studentNames) //foreach name in the string studentNames, do the following (below)
            {
                Console.WriteLine(name); // foreach name in studentNames, print name
            }


            // stack = last one in, first one out.... means replace the new "push" with the last value in the list index
            Stack<string> neames = new Stack<string>();

            names.Push("James");
            names.Push("Jacob");

            // queue = first in, first out....  
            Queue<int> a1 = new Queue<int>();

            q1.Enqueue(1);
            q1.Enqueue(2);


            //access list elements (can use a for loop or a foreach loop like in an array)

        }
    }
}
