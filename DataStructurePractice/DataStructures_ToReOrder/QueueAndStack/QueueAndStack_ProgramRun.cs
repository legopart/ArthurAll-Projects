using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataStructures.QueueAndStack;

namespace DataStructures.QueueAndStack
{
    public struct QueueAndStack_ProgramRun
    {
        public static void ProgramRun() 
        {
            Console.WriteLine("Stack:");
            Stack stack = new Stack();

            stack.Push(new Item() { Name = "cola", val = 1 });
            stack.Push(new Item() { Name = "bisli", val = 2 });
            stack.Push(new Item() { Name = "bamba", val = 3 });
            //stack.Pop();

            Console.WriteLine(stack);


            Console.WriteLine("Queue:");
            Queues queue = new Queues();

            queue.Push(new Item() { Name = "cola", val = 1 });
            queue.Push(new Item() { Name = "bisli", val = 2 });
            queue.Push(new Item() { Name = "bamba", val = 3 });
            // queue.Pop();

            Console.WriteLine(queue);
        }
    }
}
