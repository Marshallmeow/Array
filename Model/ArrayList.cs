using System;
using System.Collections.Generic;
using System.Linq;


namespace Array.Model
{

    public class ArrayQueue<T>
    {
        private T[] items;

        private T Head => items[Count > 0 ? Count - 1 : 0]; // если кол-во элементов > 0, то count -1, иначе 0
        private T Tail => items[0];
        public int MaxCount => items.Length;

        public int Count { get; private set; }

        public ArrayQueue(int size)
        {
            items = new T[size]; //установили размер массива 
            Count = 0;
        }

        //создание элемента
        public ArrayQueue(int size, T data)
        {
            items = new T[size];
            items[0] = data;
            Count = 1;
        }
        //добавление элементов, существующий массив + элемент, если кол-во не превышает
        public void Enqueue(T data)
        {

            //if (Count < MaxCount)
            //{
            //    var result = (new T[] { data }.Concat(items));
            //    items = result.ToArray();
            //    Count++;

            //}
            

            if (Count < MaxCount)
            {
                var result = new T[MaxCount];
                result[0] = data;
                for (int i = 0; i < Count; i++)
                {
                    result[i + 1] = items[i];
                }
                items = result;
                Count++;
            }
            else
            {
                if (this.isFull())
                    throw new Exception("Очередь полностью заполнена.");
            }
            
        }

        //получение элемента, с последующим удалением
        public T Dequeue()
        {
            var item = Head;
            Count--;
            return item;
        }

        //получение 1 элемента без удаления
        public T Peek()
        {

            if (this.isEmpty())
                throw new Exception("Очередь не заполнена.");
            return Head;
           // return items.ToArray()[Count -1];
        }

        //Проверка, если true, то очередь пуста
        public bool isEmpty()
        {
            return Count == 0;
        }
        //Проверка, если true, то очередь заполнена
        public bool isFull()
        {
            return Count == MaxCount;
        }


    }
}
