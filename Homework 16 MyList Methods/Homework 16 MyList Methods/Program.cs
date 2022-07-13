using System;

namespace Homework_16_MyList_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList mylist = new MyList();
            mylist.Add("Filankes");
            mylist.Add("Behmenkes");
            mylist.Get();

            mylist.Find("Filanks");
        }
    }


    public class MyList
    {
        public string[] arr;

        public MyList()
        {
            arr = new string[0];
        }

        public void Add(string str)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = str;
        }

        public void Get()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public void Find(string str)
        {
            foreach (var item in arr)
            {
                if(str == item)
                {
                    Console.WriteLine(item);
                }
               
            }
        }
    }
}
