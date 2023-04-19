using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct__Indexer__Enum.Indexer
{
    internal class ListInt
    {

        private int[] array;
        public ListInt(int length)
        {
            array = new int[length];
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
        public void Add(int num)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = num;
        }
        public void AddRange(params int[] nums)
        {
            int[] newyaradilmisarray = new int[array.Length + nums.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newyaradilmisarray[i] = array[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                newyaradilmisarray[array.Length + i] = nums[i];
            }
            array = newyaradilmisarray;
        }
        private bool Contains(int num)
        {

            foreach (var item in array)
            {
                if (num == item)
                {
                    return true;
                }

            }
            return false;
        }
        public void ShowOnConsole(int num)
        {

            if (Contains(num))
            {
                Console.WriteLine($"Arrayda {num} Reqemi Var");
            }
            else
            {
                Console.WriteLine($"Arrayda {num} Reqemi Yoxdur");
            }
        }
        public void Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine($"Arrayda Olan Reqemlerin Cemi: {sum}");
        }
        public void Remove(int num)
        {
            int[] newArray = new int[0];

            foreach (var item in array)
            {
                if (item != num)
                {
                    Array.Resize(ref newArray, array.Length + 1);
                    array[array.Length - 1] = item;
                }
            }

            array = newArray;
            Console.WriteLine($"Arraydan {num} Ededi Silindi");
        }
        public void RemoveRange(params int[] nums)
        {
            int[] newArray1 = new int[0];

            for (int i = 0; i < array.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (array[i] == nums[j])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Array.Resize(ref newArray1, newArray1.Length + 1);
                    newArray1[newArray1.Length - 1] = array[i];
                }

            }
            Console.WriteLine($"Array'dan {nums.Length} Eded Silindi.");

            array = newArray1;
        }
        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i].ToString();

            }
            return result = String.Join(",", array);
        }
    }
}