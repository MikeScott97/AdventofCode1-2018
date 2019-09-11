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

            string line;
            int tempVal = 0;
            int total = 0;
            StreamReader streamReader = new StreamReader(@"C:\Users\David\Desktop\values.txt");
            line = streamReader.ReadLine();
            while (line != null)
            {

                string giveTake = String.Empty;
                giveTake = line;
                Console.WriteLine(giveTake);

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

                Console.WriteLine(total);
                Console.WriteLine();

                line = streamReader.ReadLine();
            }
            streamReader.Close();
        }
    }
}
