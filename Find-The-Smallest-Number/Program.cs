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
            List<int> numList = new List<int>();
            int minNum;
            int num;
            int counter;

            Console.Write("Please enter the number of integers that you'd like to compare: ");
            counter = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                Console.Write("Enter integer: ");
                num = Convert.ToInt32(Console.ReadLine());

                numList.Add(num);
            }

            minNum = numList[0];

            for (int i = 0; i < numList.Count; i++)
            {
                if (numList[i] < minNum)
                {
                    minNum = numList[i];
                }
            }

            Console.WriteLine("The smallest number is " + minNum + ".");
            Console.WriteLine("Press 'enter' to close the program.");
            Console.ReadLine();
        }
    }
}
