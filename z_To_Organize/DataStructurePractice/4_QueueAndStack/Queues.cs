namespace _4_QueueAndStack
{
    public class Queues : ListingBasic
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
                newItem.Next = Head;
                Head.Prev = newItem;
                Head = newItem;
            }
            alreadyInQueue++;
        }
    }
}
