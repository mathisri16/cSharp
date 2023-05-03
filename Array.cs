using System;
using System.Collections;

namespace Array
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] intarray = new int[5]; // Same datatype and fixed size(strongly typed) 
                                         // No add and remove 
                                         // No boxing and unboxing 
                                         // 1st performmance
            int[] intArray= new int[5] {1,2,3,4,5};


            ArrayList arraylist = new ArrayList();//Differnet datatypes and variable size(loosely typed)
                                                  // Add and remove is possible 
                                                   // Neet boxing and unboxing 
                                                   // 3rd performmance
                                                   // more function

            arraylist.Add(1);
            arraylist.Add("string");


            //same datatype and variable size(strongly typed)
            // add and remove is possible
            //No  boxing and unboxing 
            // 2nd performmance
            //model best use list

            List <string> myList = new List<string>();

            myList.Add("a");
            myList.Add("b");    
            myList.Add("c");
            myList.Add("d");
            myList.Add("e");


            List<int> list = new List<int>();

            list.Add(1);

            string str = "james,bord,alex";

            string[] strarray = str.Split(',');
        }
    }
}