using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AdventofCode1_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            GrabValues();
            Console.ReadKey();
        }

        private static void GrabValues()
        {
            int[] frequencyArr = { 0};
            string line;
            int tempVal = 0;
            int total = 0;
            int listPos = 0;

            StreamReader streamReader = new StreamReader(@"C:\Users\David\Desktop\values.txt");
            line = streamReader.ReadLine();
            while (line != null)
            {
                string giveTake = String.Empty;
                //Give take is the +/- Values of the line in the txt document
                giveTake = line;
                Console.WriteLine(giveTake);
                //remove the +/- char and convert the number to int
                tempVal = Convert.ToInt32(giveTake.Substring(1));

                char plusMinus = giveTake[0];

                if (plusMinus.Equals('+'))
                {
                    total += tempVal;
                }
                else if (plusMinus.Equals('-'))
                {
                    total -= tempVal;
                }
                else
                {
                    Console.WriteLine("problem");
                }

                //for statement to check if there are similar frequencies
                foreach (int x in frequencyArr) { 
                   if(frequencyArr[x] == total)
                    {
                        Console.WriteLine("The first duplicated frequency is " + total);
                        Console.ReadKey();
                    }
                
                }

                frequencyArr[listPos] = total;

                Console.WriteLine(total);
                Console.WriteLine();

                line = streamReader.ReadLine();
            }
            streamReader.Close();
        }
    }
}
