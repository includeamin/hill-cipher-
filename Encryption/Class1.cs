//static void Main(string[] args)
//{//25 15 20 7 8 22 7 13 13
//    int[,] Key =
//    { { 25 ,15, 20 },
//              {7 ,8 ,22 },
//              { 7 ,13, 13 } };
//    //int[,] Key =
//    //{
//    //    {1, 1, 1},
//    //    {1, 1, 1},
//    //    {1, 1, 1}
//    //};

//    string input1 = Console.ReadLine();

//    int loopCount = 3 % input1.Length;
//    int GroupCount = 0;

//    int allLenght = 0;
//    StringBuilder input = new StringBuilder(input1);
//    // string input= input1;
//    for (int i = 0; i < loopCount - 1; i++)
//    {

//        input.Append((char)1);
//        allLenght++;

//    }


//    int CountOffInput = input.Length;
//    int SpliterLoopCount = CountOffInput / 3;
//    int lastSeenCount = 0;

//    char[,] temp = new char[3, input.Length];
//    for (int i = 0; i < SpliterLoopCount; i++)
//    {
//        for (int j = 0; j < 3; j++)
//        {

//            temp[j, i] = input[lastSeenCount];
//            lastSeenCount++;
//        }
//    }
//    for (int i = 0; i < 3; i++)
//    {
//        for (int j = 0; j < SpliterLoopCount; j++)
//        {
//            Console.Write(" " + (int)temp[i, j] + " ");
//        }

//        Console.WriteLine();
//    }

//    Console.WriteLine("-----------------------");
//    int[,] tempOut = new int[3, SpliterLoopCount];

//    int rowCount = 0;

//    for (int i = 0; i < SpliterLoopCount; i++)
//    {
//        for (int j = 0; j < 3; j++)
//        {


//            tempOut[j, i] = temp[0, i] * Key[j, 0] +
//                            temp[1, i] * Key[j, 1] +
//                            temp[2, i] * Key[j, 2];



//        }
//    }

//    string FinalOutPut = "";

//    for (int i = 0; i < SpliterLoopCount; i++)
//    {
//        for (int j = 0; j < 3; j++)
//        {



//            Console.Write($" {tempOut[j, i] % 122 % 122} ");

//            FinalOutPut += (char)((tempOut[j, i] % 122));



//        }
//        Console.WriteLine();
//    }
//    //for (int i = 0; i < 3; i++)
//    //{
//    //    for (int j = 0; j < SpliterLoopCount; j++)
//    //    {
//    //        Console.Write(" " + tempOut[+ " ");
//    //    }

//    //    Console.WriteLine();
//    //}

//    Console.Read();

//}