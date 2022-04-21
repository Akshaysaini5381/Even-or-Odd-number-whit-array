using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even__or_Odd_number_whit_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
         

            Console.Write("Enter the array size : ");
            size = int.Parse(Console.ReadLine());

            Console.WriteLine("My array Size {0} : ",size);
            int[] arr= new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter the Element of array {0} :",i+1);
                arr[i] = int.Parse(Console.ReadLine());
             
            }
         
            for (int i = 0; i < size; i++)
            {
                if(arr[i]%2==0)
                {
                    Console.WriteLine("Even number {0}  ",i);
                }
            }


            Console.WriteLine("==================");
            for (int i = 0; i < size; i++)
            {
                if (arr[i]%2!= 0)
                {
                    Console.WriteLine("Odd number {0}  ", i);
                }
            }
            Console.ReadLine();

        }
    }
}
