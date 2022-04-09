using System;
namespace InsertionSortDemo
{
    public class Program
    {
        public static void Main(string[]args)
        {
            int[] arr = { 12, 85, 96, 15, 45, 9 };
            for(int i = 1; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while(j >= 0 && arr[j]> temp)
                {
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j+1] = temp;
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
