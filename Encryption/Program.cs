using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Encryption
{
    class Program
    {
        private static string[] alphabet = new String[]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
            "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };
        static void Main(string[] args)
        {//25 15 20 7 8 22 7 13 13
            //int[,] Key =
            //{ { 25 ,15, 20 },
            //  {7 ,8 ,22 },
            //  { 7 ,13, 13 } };
            //int[,] Key =
            //{
            //    {1, 1, 1},
            //    {1, 1, 1},
            //    {1, 1, 1}
            //};
            int[,] Key =
            {
                {15, 2, 12},
                {8, 19, 13},
                {24, 25, 10}
            };
          
          
            string input1 = Console.ReadLine();
            
            int loopCount =  3 % input1.Length;
          

            StringBuilder input = new StringBuilder(input1);
           // string input= input1;
            for (int i = 0; i < loopCount-1; i++)
            {
              
                input.Append((char) 97);
               

            }


            int CountOffInput = input.Length;
            int SpliterLoopCount = CountOffInput / 3;
            int lastSeenCount = 0;

            int[,] temp = new int[3, input.Length];
            for (int i = 0; i < SpliterLoopCount; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                 
                    temp[j, i] = input[lastSeenCount]-97;
                    lastSeenCount++;
                }
            }

            //for (int i = 0; i < 3; i++)
            //{
            //    for (int j = 0; j < SpliterLoopCount; j++)
            //    {
            //        Console.Write(" " + (temp[i, j]-97) + " ");
            //    }

            //    Console.WriteLine();
            //}


       


            Console.WriteLine("-----------------------");

            double[,] tempOut = new Double[3,SpliterLoopCount];

            for (int i = 0; i < SpliterLoopCount; i++)
            {
                for (int j = 0; j < 3; j++)
                {


                    tempOut[j, i] = temp[0, i] * Key[j, 0] +
                                    temp[1, i] * Key[j, 1] +
                                    temp[2, i] * Key[j, 2];


                }
            }


            string FinalOutPut ="";

            for (int i = 0; i < SpliterLoopCount; i++)
            {
                for (int j = 0; j < 3; j++)
                {


                    
                    Console.Write( $" {tempOut[j, i] %26} ");

                    FinalOutPut += alphabet[(int) (tempOut[j, i] % 26)];



                }
                Console.WriteLine();
            }

            Console.WriteLine(FinalOutPut);

 
            Console.Read();
            
        }
    }
}
