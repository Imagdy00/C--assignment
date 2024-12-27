namespace DEMO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region One-Dimensional Array
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion


            #region Two-Dimensional Array (Rectangle)
            //    int[,] matrix = {
            //    { 1, 2, 3 },
            //    { 4, 5, 6 },
            //    { 7, 8, 9 }
            //};

            //    for (int i = 0; i < matrix.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < matrix.GetLength(1); j++)
            //        {
            //            Console.Write(matrix[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            #endregion


            #region Two-Dimensional Array (Jagged Array)
            //int[][] jaggedArray = new int[3][];
            //jaggedArray[0] = new int[] { 1, 2 };
            //jaggedArray[1] = new int[] { 3, 4, 5 };
            //jaggedArray[2] = new int[] { 6 };

            //foreach (var row in jaggedArray)
            //{
            //    foreach (var item in row)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            #region Function Prototype and Calling

            //GreetUser("Mohammed");
            //static void GreetUser(string name)
            //{
            //    Console.WriteLine($"Hello, {name}!");
            //}
            #endregion


            #region Functions Stack Frame
            //Console.WriteLine("Main Start");
            //FunctionA();
            //Console.WriteLine("Main End");

            //static void FunctionA()
            //{
            //    Console.WriteLine("In Function A");
            //    FunctionB();
            //}

            //static void FunctionB()
            //{
            //    Console.WriteLine("In Function B");
            //}
            #endregion


            #region Passing Parameters - Value Type

            //int number = 10;
            //Console.WriteLine($"Before: {number}");
            //Increment(number);
            //Console.WriteLine($"After: {number}");
            //static void Increment(int value)
            //{
            //    value++;
            //    Console.WriteLine($"Inside: {value}");
            //}
            #endregion


            #region Passing Parameters - Reference Type Example 1
            //int[] numbers = { 1, 2, 3 };
            //ModifyArray(numbers);
            //Console.WriteLine($"First Element: {numbers[0]}");
            //static void ModifyArray(int[] arr)
            //{
            //    arr[0] = 100;
            //}
            #endregion


            #region Passing Parameters - Reference Type Example 2
            //string name = "Original";
            //ModifyString(ref name);
            //Console.WriteLine(name);

            //static void ModifyString(ref string str)
            //{
            //    str = "Modified";
            //}


            #endregion



            #region Passing by out
            //int result;
            //CalculateSum(5, 10, out result);
            //Console.WriteLine($"Sum: {result}");
            //static void CalculateSum(int a, int b, out int sum)
            //{
            //    sum = a + b;
            //}
            #endregion


            #region Using params
            //int total = AddNumbers(1, 2, 3, 4, 5);
            //Console.WriteLine($"Total: {total}");

            //static int AddNumbers(params int[] numbers)
            //{
            //    int sum = 0;
            //    foreach (int number in numbers)
            //    {
            //        sum += number;
            //    }
            //    return sum;
            //}
            #endregion
        }
    }
}
