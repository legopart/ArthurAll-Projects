namespace _4_QueueAndStack
{
    public class Stack : ListingBasic
    {
        public void Push(Item newItem)
        {
            if (Head == null)
            {
                // Empty queue, this is the first item in queue
                Head = newItem;
                Tail = newItem;
            }
            else
            {
                newItem.Prev = Tail;
                Tail.Next = newItem;
                Tail = newItem;
            }
            alreadyInQueue++;
        }
    }
}
