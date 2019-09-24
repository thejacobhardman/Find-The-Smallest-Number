using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_The_Smallest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = new int[0];
            int minNum;
            int num;
            int counter;

            Console.WriteLine("Please enter the number of integers that you'd like to compare: ");
            counter = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine("Enter integer: ");
                num = Convert.ToInt32(Console.ReadLine());

                numArr.Append(num);
                Console.WriteLine(numArr);
            }

            minNum = numArr[0];

            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] < minNum)
                {
                    minNum = numArr[i];
                }
            }

            Console.WriteLine("The smallest number is " + minNum + ".");
            Console.WriteLine("Press 'enter' to close the program.");
            Console.ReadLine();
        }
    }
}
