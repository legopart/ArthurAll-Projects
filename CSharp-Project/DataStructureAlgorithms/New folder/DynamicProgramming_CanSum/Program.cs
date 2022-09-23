namespace Can_Sum
{
    class Program
    {
        static void Main()
        {

        }


        // CanSum

        // canSum(7, [5, 3, 4, 7]) -> true
        //          7
        //      2   4   3   0   for7 , after traveling

        // canSum(7, [2, 4]) -> false

        public static bool CanSum(int sumTarget, int[] numbers) // O(n^m) space O(m)    m=targer sum n=array length
        {
            if (sumTarget == 0) return true;
            if (sumTarget < 0) return false;
            foreach (var num in numbers)    //after all possibilities
            {
                var remainder = sumTarget - num;
                if(CanSum(remainder, numbers)) return true ;
            }
            return false;
        }




    }
}