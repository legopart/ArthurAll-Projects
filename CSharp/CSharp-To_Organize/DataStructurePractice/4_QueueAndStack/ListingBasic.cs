namespace _4_QueueAndStack
{
    public class ListingBasic
    {
        public Item Head = null;
        public Item Tail = null;
        public int alreadyInQueue = 0;

        public Item Pop()
        {
            Item popedHead = Head;

            if (Head == null)
                return null;

            if (Head.Next == null)
            {
                Head = null;
                Tail = null;
                alreadyInQueue--;
                return popedHead;
            }

            Head.Next.Prev = null;
            Head = Head.Next;
            alreadyInQueue--;
            return popedHead;

        }

        public override string ToString()
        {
            string str = $"Your Item Order is:\n";
            Item printItem = Head;
            int i = 0;
            while (printItem != null)
            {
                str += $"{i++} \t Item Name: {printItem.Name} \t \t Item Value: {printItem.val}\n";
                printItem = printItem.Next;
            }
            str += $"Total items in quequ is: {alreadyInQueue}\nGood Day.\n";

            return str;
        }
    }
}
