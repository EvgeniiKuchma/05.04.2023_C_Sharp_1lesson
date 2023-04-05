using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    internal class Program
    {
       static void myConvert (string _promt, out int? a) //позволяет при вызове функции указать 2 м параметром куда мы это хотим сложить. int? расширенный тип данных которых может хранить null
       {
            //int a = 0;
            a = null;
            Console.WriteLine(_promt);
            try
            {
                a = int.Parse(Console.ReadLine());           
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           // return a;
       }
        static void Main(string[] args)
        {
            /*int a1 = 4;
            char b1 = '6';
            Console.WriteLine(a1+(int)b1);

            int a = 4;
            string b = "6";
            Console.WriteLine(a + int.Parse(b));
            */

            /*int a = 4, a1;
            string b = "6a";
            try
            {
                Console.WriteLine(a + int.Parse(b));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();*/

           int a = 4;
           int? a1 = null;
           string b = "6a";
            while(a1 == null)
            {
                myConvert("Enter number: ", out a1);
            }
           Console.WriteLine(a1);
           int[] arr = new int[3]{1,2,3};
           foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            var _list = new List<int>();
            for (int i = 0; i <arr.Length; i++)
            {
                _list.Add(arr[i]);
                Console.WriteLine(_list[i]);
            }
            _list.Add(-7);
            int counter = 0;
            foreach (var item in _list)
            {
                counter++;  
                Console.WriteLine("Element {0} = {1} \n",counter,item );//placeholder {0},{1}
                Console.WriteLine($"Element {counter} =  {item}\n");//$ обозначение работы сразу с переменными, @ игнорирование ескейп последовательности
            }
           Console.ReadKey();
        }
    }
}
