namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            //static void PassByValue(int x)
            //{
            //    x = 10;
            //}

            //static void PassByReference(ref int x)
            //{
            //    x = 10;
            //}


            //static void ValueTypeExample()
            //{
            //    int num = 5;
            //    Console.WriteLine($"Before PassByValue: {num}");
            //    PassByValue(num);
            //    Console.WriteLine($"After PassByValue: {num}");

            //    Console.WriteLine($"Before PassByReference: {num}");
            //    PassByReference(ref num);
            //    Console.WriteLine($"After PassByReference: {num}");
            //}
            #endregion

            #region 2

            //static void PassByValueRefType(string s)
            //{
            //    s = "Changed";
            //}

            //static void PassByReferenceRefType(ref string s)
            //{
            //    s = "Changed";
            //}

            //static void ReferenceTypeExample()
            //{
            //    string str = "Original";
            //    Console.WriteLine($"Before PassByValueRefType: {str}");
            //    PassByValueRefType(str);
            //    Console.WriteLine($"After PassByValueRefType: {str}");

            //    Console.WriteLine($"Before PassByReferenceRefType: {str}");
            //    PassByReferenceRefType(ref str);
            //    Console.WriteLine($"After PassByReferenceRefType: {str}");
            //}
            #endregion


            #region 3
            //static (int, int) SumAndSubtract(int a, int b, int c, int d)
            //{
            //    return (a + b + c + d, a - b - c - d);
            //}
            #endregion


            #region 4
            //static int SumOfDigits(int number)
            //{
            //    int sum = 0;
            //    while (number != 0)
            //    {
            //        sum += number % 10;
            //        number /= 10;
            //    }
            //    return sum;
            //}
            #endregion


            #region 5
            //static bool IsPrime(int number)
            //{
            //    if (number <= 1) return false;
            //    for (int i = 2; i < Math.Sqrt(number) + 1; i++)
            //    {
            //        if (number % i == 0) return false;
            //    }
            //    return true;
            //}
            #endregion


            #region 6
            //static void MinMaxArray(int[] arr, out int min, out int max)
            //{
            //    min = int.MaxValue;
            //    max = int.MinValue;
            //    foreach (var num in arr)
            //    {
            //        if (num < min) min = num;
            //        if (num > max) max = num;
            //    }
            //}
            #endregion


            #region 7
            //static int Factorial(int number)
            //{
            //    int result = 1;
            //    for (int i = 2; i <= number; i++)
            //        result *= i;
            //    return result;
            //}
            #endregion


            #region 8
            //static string ChangeChar(string input, int index, char newChar)
            //{
            //    if (index < 0 || index >= input.Length)
            //        throw new ArgumentOutOfRangeException("Index out of range");

            //    char[] chars = input.ToCharArray();
            //    chars[index] = newChar;
            //    return new string(chars);
            //}
            #endregion



            #region 9
            //static void IdentityMatrix(int n)
            //{
            //    for (int i = 0; i < n; i++)
            //    {
            //        for (int j = 0; j < n; j++)
            //            Console.Write(i == j ? "1 " : "0 ");
            //        Console.WriteLine();
            //    }
            //}
            #endregion


            #region 10
            //static int SumArray(int[] arr)
            //{
            //    int sum = 0;
            //    foreach (int num in arr) sum += num;
            //    return sum;
            //}
            #endregion



            #region 11
            //static int[] MergeArrays(int[] arr1, int[] arr2)
            //{
            //    int[] merged = new int[arr1.Length + arr2.Length];
            //    Array.Copy(arr1, merged, arr1.Length);
            //    Array.Copy(arr2, 0, merged, arr1.Length, arr2.Length);
            //    Array.Sort(merged);
            //    return merged;
            //}
            #endregion


            #region 12
            //static void FrequencyCount(int[] arr)
            //{
            //    var freq = new Dictionary<int, int>();
            //    foreach (int num in arr)
            //    {
            //        if (!freq.ContainsKey(num))
            //            freq[num] = 0;
            //        freq[num]++;
            //    }
            //    foreach (var pair in freq)
            //        Console.WriteLine($"{pair.Key}: {pair.Value}");
            //}

            #endregion


            #region 13
            //static void FindMaxMin(int[] arr, out int max, out int min)
            //{
            //    max = arr[0];
            //    min = arr[0];
            //    foreach (var num in arr)
            //    {
            //        if (num > max) max = num;
            //        if (num < min) min = num;
            //    }
            //}
            #endregion



            #region 14
            //static int SecondLargest(int[] arr)
            //{
            //    Array.Sort(arr);
            //    return arr[arr.Length - 2];
            //}
            #endregion



            #region 15
            //static int LongestDistance(int[] arr)
            //{
            //    var dict = new Dictionary<int, int>();
            //    int maxDistance = 0;
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (dict.ContainsKey(arr[i]))
            //            maxDistance = Math.Max(maxDistance, i - dict[arr[i]]);
            //        else
            //            dict[arr[i]] = i;
            //    }
            //    return maxDistance;
            //}
            #endregion


            #region 16
            //static string ReverseWords(string sentence)
            //{
            //    var words = sentence.Split(' ');
            //    Array.Reverse(words);
            //    return string.Join(" ", words);
            //}
            #endregion



            #region 17
            //static void CopyMultiDimArray()
            //{
            //    int[,] array1 = new int[2, 2];
            //    int[,] array2 = new int[2, 2];

            //    for (int i = 0; i < 2; i++)
            //        for (int j = 0; j < 2; j++)
            //        {
            //            Console.Write($"Enter value for array1[{i},{j}]: ");
            //            array1[i, j] = int.Parse(Console.ReadLine());
            //            array2[i, j] = array1[i, j];
            //        }

            //    Console.WriteLine("Copied Array:");
            //    for (int i = 0; i < 2; i++)
            //    {
            //        for (int j = 0; j < 2; j++)
            //            Console.Write(array2[i, j] + " ");
            //        Console.WriteLine();
            //    }
            //}

            #endregion


            #region 18
            //static void ReverseArray(int[] arr)
            //{
            //    Array.Reverse(arr);
            //    Console.WriteLine(string.Join(" ", arr));
            //}
            #endregion


            #region 19
            //static void PrintReverseArray(int[] arr)
            //{
            //    Console.WriteLine("Array in reverse order:");
            //    for (int i = arr.Length - 1; i >= 0; i--)
            //    {
            //        Console.Write(arr[i] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
        }
    }
}
