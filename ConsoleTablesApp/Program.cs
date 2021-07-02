using System;
using System.Linq;
using ConsoleTables;
using System.Collections.Generic;

namespace ConsoleTablesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var table = new ConsoleTable(" ", "A", "B", "C", "D", "E");
           for (int i = 0; i < 8; i++)
           {
               table.AddRow(i+1, " ", " ", " ", " ", " ");
           }
            
            table.Write();
           
            Console.WriteLine();

            var column = table.Columns;
            var row = table.Rows;
            var seatnumber = column.row;   
            
            

            Dictionary<string, string> bookSeats = new Dictionary<string, string>();


            bookSeats.Add("A1", "Felicia Robinson");
            bookSeats.Add("A2", "Maggie Robinson");

            foreach(KeyValuePair<string, string> item in bookSeats)
            {
                Console.WriteLine($"The Key is: {item.Key} - The Value is: {item.Value} ");
            }
            Console.ReadLine();
            

            /* 1. Create a table  where the columns span from A-E. The rows span from 1-8.
                1a. Create dictionary, and then Iterate over the seatnumbers to see the space that should have "X"
               2. Check to see whether or not a seatnumber is null or if it is occupied by "X"
               3. If it not occupied by "X", print "This seat is available!".
                3a. Then assign a name to the seatnumber, and print X in the seatnumber.
                3b. The data structure that I use to assign the name to the seatnumber will be the same 
                data structure I use to showcase whether a seatnumber has a space or an "X"
                3c. This will be a dictionary... "If this seatnumber is associated with a name, print "X"
                3d. The seatnumber should be the key in the key-value pair.
               4. If it is occupied, print "This seat is occupied".
            */
            
        }
    }      
}
