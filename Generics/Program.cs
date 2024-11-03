using System;
using System.Collections.Generic;

namespace Generics
{
    //Задание 1
    public class Pair<T, U>
    {
        private T _first;
        private U _second;

        public Pair(T first, U second)
        {
            _first = first;
            _second = second;
        }
        public T GetFirstElem()
        {
            return _first;
        }
        public U GetSecondElem()
        {
            return _second;
        }
        public void SetFirstElem(T first)
        {
            _first = first;
        }
        public void SetSecondElem(U second)
        {
            _second = second;
        }
    }

    //Задание 2 - ниже

    //Задание 3
    public class Repository<T> where T : class
    {
        private List<T> items;

        public Repository()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }

            return items[index];
        }

        public int Count => items.Count;
    }

    //Задание 4 - ниже

    //Задание 5
    public interface IStorage<T>
    {
        void Add(T item);
        T Get(int index);
        int Count { get; }
    }
    public class ListStorage<T> : IStorage<T>
    {
        private List<T> items;

        public ListStorage()
        {
            items = new List<T>();
        }
        public void Add(T item)
        {
            items.Add(item);
        }
        public T Get(int index)
        {
            if (index < 0 || index >= items.Count)
            {
                throw new ArgumentOutOfRangeException("Index out of range");
            }

            return items[index];
        }
        public int Count => items.Count;
    }


    class Program
    {
        public static void Main(string[] args)
        {

        }

        //Задание 2
        public static T FindMin<T>(T[] array) where T : IComparable
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array can't be null or empty");
            }

            T minValue = array[0];

            foreach (T item in array)
            {
                if (item.CompareTo(minValue) < 0)
                {
                    minValue = item;
                }
            }
            return minValue;
        }

        //Задание 4
        public static void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}

