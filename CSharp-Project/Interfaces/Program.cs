using System;
using System.Net;
using System.Text;  // For class Encoding
using System.IO;
using System.Net.Http;
using System.Collections.Generic;

namespace Interfaces
{



    public interface IArea
    {
        // Interfaces are created and owned by the caller
        // The calee depends on ad implements the interface (dependency inversion)
        double GetArea();
    }

    public class Rectangle : IArea
    {
        private double Radios { get; set; }
        private String? Color { get; set; }
        public Rectangle(double radios) {  Radios = radios; }
        //public Rectangle(double radios, String color) : this(radios) { Color = color; }
        public double GetArea() { return Radios * Radios * Math.PI; }
    }


    public class Program
    {
        public static double AreaCycleCombiner(params double[] radiosArray)
        {
            double totalSum = 0.0;
            foreach (var radios in radiosArray) 
            {
                IArea cycleX = new Rectangle(radios);
                totalSum += cycleX.GetArea();
            }
            //radiosArray.Sum( (radios) =>
            //    {
            //        IArea cycleX = new Rectangle(radios);
            //        totalSum += cycleX.GetArea();
            //        return totalSum;
            //    }
            //);
            return totalSum;
        }


        public static double AreaCycleCombiner2(double radios1, double radios2)
        {
            IArea cycle1 = new Rectangle(radios1);
            IArea cycle2 = new Rectangle(radios2);

            double cycle1Area = cycle1.GetArea();
            double cycle2Area = cycle2.GetArea();
            double cycleSum = cycle1Area + cycle2Area;
            return cycleSum;
        }

        private static void Main(string[] args)
        {

            double cyclesAreaSums = AreaCycleCombiner( 2.0, 3.0 ); //(new double[] { 2.0, 3.0 });
            Console.WriteLine("Interfaces");

            Console.WriteLine("The Cycles 2, 3 Area Sum: " + cyclesAreaSums);    // ~40.841



        }
    }
}

