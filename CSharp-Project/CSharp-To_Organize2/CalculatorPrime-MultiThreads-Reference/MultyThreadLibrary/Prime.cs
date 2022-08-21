using System;
using System.Collections.Generic;

namespace MultyThreadLibrary
{
    public struct Prime
    {
        /*TODO*/
        //fix to long (or replace list method):  int index = PrimeList.IndexOf(newStart) - 1;    //??? (int) 

        public static List<long> PrimeList = new List<long>(); //organizing sorted list for prime numbers, not incloades 2
        public static long LastCheckedIfPrime { get; private set; } = 2;
        public static bool IsPrimes_WithPrimeList(long check, long startPoint = 3) //only bigger then 2 and uneven
        {
            long currentPoint = startPoint;
            long last = LastCheckedIfPrime;
            if (last < check)   // check awailable PrimeList
            {
                foreach (long i in PrimeList)
                    if (check % i == 0) return false;
                currentPoint = last;
            }
            else if (last == check) return true;    //!
                //else if (last > check) return false;    //unused check
            
            while (currentPoint < ((check + 1) / 2))
            {
                if (check % currentPoint == 0) return false;
                if (last < currentPoint) { 
                    PrimeList.Add(currentPoint);
                    LastCheckedIfPrime = currentPoint;
                }
                currentPoint += 2;
            }
            return true;
        }

        //Original Basic IsPrime for 3 and more !
        public static bool IsPrimes(long check) //look only for uneven nobers bigger then 2
        {
            long x = 3;
            while (x <= (long)((check + 1) / 2)) { if (check % x == 0) return false; x += 2; } 
            return true;
        }   
        

        public static List<long> GetPrimesList(long start, long stop)
        {
            List<long> list = new List<long>();
            long newStart = start;
            if(newStart < 3) {
                if (newStart < 0 || stop < 0) return list;
                if (newStart < 2) newStart = 2; // x = 2
                if (newStart > stop) return list;
                if (newStart == 2) list.Add(2);    //set 2
            }
            if (newStart % 2 == 0) newStart++; // fix to uneven numbers 5,7,9...
            if (newStart > stop) return list;   //continue from 2, ... and with uneven, and with condition Start > Stop
            if (PrimeList.Count > 0)
            {   //move previus list to new one
                long last = PrimeList[PrimeList.Count - 1];
                int index = PrimeList.IndexOf(newStart) - 1;    //??? (int)
                while (index >= 0 && newStart <= last)
                {
                    list.Add(PrimeList[index]);
                    newStart = PrimeList[index];
                    index++;
                }
            }
            while (newStart <= stop)
            {
                if (IsPrimes_WithPrimeList(newStart)) list.Add(newStart); //New version Check bases on IsPrime
                //if (IsPrimes(newStart)) list.Add(newStart); //Original Basic Version 
                newStart += 2;    //look only for uneven nobers
            }
            return list;
        }


    }
}
