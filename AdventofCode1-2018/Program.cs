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
            List<int> frequencyList = new List<int>();
            string line;
            int tempVal = 0;
            int total = 0;
            int reiterate = 0;

            StreamReader streamReader = new StreamReader(@"C:\Users\David\Desktop\values.txt");
            line = streamReader.ReadLine();
            while (reiterate == 0)
            {
                if(line == null)
                {
                    streamReader.DiscardBufferedData();
                    streamReader.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);

                    line = streamReader.ReadLine();
                }
                frequencyList.Add(total);

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
                for (int x = 0; x < frequencyList.Count; x++) { 
                   if(frequencyList[x] == total)
                    {







                        Console.WriteLine("The first duplicated frequency is " + total);
                        reiterate = 1;
                        Console.ReadKey();
                    }
                }

                Console.WriteLine(total);
                Console.WriteLine();

                line = streamReader.ReadLine();
                }
            streamReader.Close();
        }
    }
}
