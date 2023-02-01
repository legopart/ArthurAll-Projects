


using System;
using TestPreppering.Forms;
using TestPreppering.Math;

namespace TestPreppering {

    class Program
    {
        static void Main(string[] args)
        {

                        Console.WriteLine("\n\nDuplicate Table 1-100");
            Duplicate1_100.DuplicateTable();
                        Console.WriteLine("\n\nPrime Numbers 1-100");
            PrimeNumbers1_100.PrimeNumbers();
                        //Prime Numbers 1-100 The must short way with counter
          //  PrimeNumbers1_100_Shortly_wCounter.PrimeNumbers_wCounter();



            Console.WriteLine("\n\nRectangle");
            Rectangle.RectangleEmpty(7, 14);
                            Console.WriteLine("\n\n Triangle");
            Triangle.TriangleEmpty(7);
                            Console.WriteLine("\n\n Triangle Reversed");
            TriangleReversed.TriangleReversedEmpty(7);
                            //Triangle Reversed Empty Simetry
          //  TriangleReversedSimetry.TriangleReversedEmptySimetry(7);
                            Console.WriteLine("\n\nMagen David");
            MagenDavid.MagenDavidEmpty(7);
                            Console.WriteLine("\n\nEmpty Diamond");
            Diamond.DiamondEmpty(7);
                            Console.WriteLine("\n\n");

            
        }
    } 
}



