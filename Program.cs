using System;
using Array.Model;


    class Program
    {
        static void Main(string[] args)
        {
        var arrayQueue = new ArrayQueue<int>(10);
        arrayQueue.Enqueue(1);
        arrayQueue.Enqueue(2);
        arrayQueue.Enqueue(3);
        arrayQueue.Enqueue(4);
        arrayQueue.Enqueue(5);
        arrayQueue.Enqueue(6);

        Console.WriteLine(arrayQueue.Dequeue());
        Console.WriteLine(arrayQueue.Dequeue());
        Console.WriteLine(arrayQueue.Dequeue());
        Console.WriteLine(arrayQueue.Dequeue());
        Console.WriteLine(arrayQueue.Dequeue());
        Console.WriteLine(arrayQueue.Peek());

        Console.ReadLine();


        //Console.WriteLine("Enter max number of elements");
        //int max = Convert.ToInt32(Console.ReadLine());
        //var arrayQueue = new ArrayQueue<int>(max);

        //Console.WriteLine("Enter elements");
        //int count = Convert.ToInt32(Console.ReadLine());
        //for (int i = 0; i < count; i++)
        //{
        //    arrayQueue.Enqueue(count);
        //    Console.WriteLine(arrayQueue.Dequeue());
        //}
    }
    }

