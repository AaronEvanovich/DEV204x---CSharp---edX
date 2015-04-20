using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Description: Module Two Assignment.
// Author: Javier Herrero Arnanz.

namespace Module_2_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Board Size.
            int row_Size = 8;
            int col_Size = 8;

            // Print Board.
            for (int row = 0; row < row_Size; row++)
            {
                for (int col = 0; col < col_Size; col++)
                {
                    if (((row + col) % 2) == 0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write("O");
                    }
                }
                Console.WriteLine(""); // New Line
            }
        }
    }
}
