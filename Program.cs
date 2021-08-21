using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInt = { 1, 2, 3, 4 };
            int poped = ArrayHelper.Pop(ref arrInt);
            ShowArr(arrInt);
            ArrayHelper.Push(ref arrInt, 10);
            ShowArr(arrInt);
            int shifted = ArrayHelper.Shift(ref arrInt);
            ShowArr(arrInt);
            ArrayHelper.UnShift(ref arrInt, 6);
            ShowArr(arrInt);
        }
        static void ShowArr<T>(T[] arr)
        {
            foreach (T item in arr)
                System.Console.Write($"\t{item}");
            System.Console.WriteLine();
        }
    }
    static class ArrayHelper
    {
        public static int Pop(ref int[] arr)
        {
            if (arr.Length == 0) return 0;
            int[] resArr = new int[arr.Length - 1];
            int res = arr[arr.Length - 1];
            for (int i = 0; i < resArr.Length; i++)
                resArr[i] = arr[i];
            arr = resArr;
            return res;
        }
        public static int Push(ref int[] arr, int x)
        {
            if (arr.Length == 0) return 0;
            int[] resArr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
                resArr[i] = arr[i];
            resArr[arr.Length] = x;
            arr = resArr;
            return resArr.Length;
        }
        public static int Shift(ref int[] arr)
        {
            if (arr.Length == 0) return 0;
            int[] resArr = new int[arr.Length - 1];
            int res = arr[0];
            for (int i = 0; i < resArr.Length; i++)
                resArr[i] = arr[i + 1];
            arr = resArr;
            return res;
        }
        public static int UnShift(ref int[] arr, int x)
        {
            if (arr.Length == 0) return 0;
            int[] resArr = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
                resArr[i + 1] = arr[i];
            resArr[0] = x;
            arr = resArr;
            return resArr.Length;
        }
        public static double Pop(ref double[] arr)
        {
            if (arr.Length == 0) return 0;
            double[] resArr = new double[arr.Length - 1];
            double res = arr[arr.Length - 1];
            for (int i = 0; i < resArr.Length; i++)
                resArr[i] = arr[i];
            arr = resArr;
            return res;
        }
        public static int Push(ref double[] arr, double x)
        {
            if (arr.Length == 0) return 0;
            double[] resArr = new double[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
                resArr[i] = arr[i];
            resArr[arr.Length] = x;
            arr = resArr;
            return resArr.Length;
        }
        public static double Shift(ref double[] arr)
        {
            if (arr.Length == 0) return 0;
            double[] resArr = new double[arr.Length - 1];
            double res = arr[0];
            for (int i = 0; i < resArr.Length; i++)
                resArr[i] = arr[i + 1];
            arr = resArr;
            return res;
        }
        public static int UnShift(ref double[] arr, double x)
        {
            if (arr.Length == 0) return 0;
            double[] resArr = new double[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
                resArr[i + 1] = arr[i];
            resArr[0] = x;
            arr = resArr;
            return resArr.Length;
        }
        public static float Pop(ref float[] arr)
        {
            if (arr.Length == 0) return 0;
            float[] resArr = new float[arr.Length - 1];
            float res = arr[arr.Length - 1];
            for (int i = 0; i < resArr.Length; i++)
                resArr[i] = arr[i];
            arr = resArr;
            return res;
        }
        public static int Push(ref float[] arr, float x)
        {
            if (arr.Length == 0) return 0;
            float[] resArr = new float[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
                resArr[i] = arr[i];
            resArr[arr.Length] = x;
            arr = resArr;
            return resArr.Length;
        }
        public static float Shift(ref float[] arr)
        {
            if (arr.Length == 0) return 0;
            float[] resArr = new float[arr.Length - 1];
            float res = arr[0];
            for (int i = 0; i < resArr.Length; i++)
                resArr[i] = arr[i + 1];
            arr = resArr;
            return res;
        }
        public static int UnShift(ref float[] arr, float x)
        {
            if (arr.Length == 0) return 0;
            float[] resArr = new float[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
                resArr[i + 1] = arr[i];
            resArr[0] = x;
            arr = resArr;
            return resArr.Length;
        }
        public static decimal Pop(ref decimal[] arr)
        {
            if (arr.Length == 0) return 0;
            decimal[] resArr = new decimal[arr.Length - 1];
            decimal res = arr[arr.Length - 1];
            for (int i = 0; i < resArr.Length; i++)
                resArr[i] = arr[i];
            arr = resArr;
            return res;
        }
        public static int Push(ref decimal[] arr, decimal x)
        {
            if (arr.Length == 0) return 0;
            decimal[] resArr = new decimal[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
                resArr[i] = arr[i];
            resArr[arr.Length] = x;
            arr = resArr;
            return resArr.Length;
        }
        public static decimal Shift(ref decimal[] arr)
        {
            if (arr.Length == 0) return 0;
            decimal[] resArr = new decimal[arr.Length - 1];
            decimal res = arr[0];
            for (int i = 0; i < resArr.Length; i++)
                resArr[i] = arr[i + 1];
            arr = resArr;
            return res;
        }
        public static int UnShift(ref decimal[] arr, decimal x)
        {
            if (arr.Length == 0) return 0;
            decimal[] resArr = new decimal[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
                resArr[i + 1] = arr[i];
            resArr[0] = x;
            arr = resArr;
            return resArr.Length;
        }
        public static string Pop(ref string[] arr)
        {
            if (arr.Length == 0) return null;
            string[] resArr = new string[arr.Length - 1];
            string res = arr[arr.Length - 1];
            for (int i = 0; i < resArr.Length; i++)
                resArr[i] = arr[i];
            arr = resArr;
            return res;
        }
        public static int Push(ref string[] arr, string x)
        {
            if (arr.Length == 0) return 0;
            string[] resArr = new string[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
                resArr[i] = arr[i];
            resArr[arr.Length] = x;
            arr = resArr;
            return resArr.Length;
        }
        public static string Shift(ref string[] arr)
        {
            if (arr.Length == 0) return null;
            string[] resArr = new string[arr.Length - 1];
            string res = arr[0];
            for (int i = 0; i < resArr.Length; i++)
                resArr[i] = arr[i + 1];
            arr = resArr;
            return res;
        }
        public static int UnShift(ref string[] arr, string x)
        {
            if (arr.Length == 0) return 0;
            string[] resArr = new string[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
                resArr[i + 1] = arr[i];
            resArr[0] = x;
            arr = resArr;
            return resArr.Length;
        }
    }
}
