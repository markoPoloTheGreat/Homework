using System.Numerics;
using Homework;
//mark
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Success(4));
    }
    public static string Decode(string input,int code)
    {// question 2
        char[] abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] arr= input.ToCharArray();
        int currPlace;
        int newPlace;
        for (int i = 0; i < abc.Length; i++)
        {
            currPlace = Array.IndexOf(abc, arr[i]);
            newPlace = (currPlace+code) % abc.Length;
            arr[i] = abc[newPlace];
        }
        string result="";
        for (int i = 0;i < arr.Length;i++)
        {
            result += arr[i];
        }
        return result;
    }
    public static string CheckFlight(Flight[] arr, string orig,string dest)
    {//question 5
        string result = "";
        for(int i = 0; i<arr.Length; i++)
        {
            if (arr[i].GetOrigin() == orig)
            {
                result += 'O';
            }
        }
        if(result.Length == 0)
        {
            result += 'X';
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].GetDestination() == dest)
            {
                result += 'D';
            }
        }
        if (result.Length == 1)
        {
            result += 'X';
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if ((arr[i].GetOrigin() == orig) &&(arr[i].GetDestination() == dest))
            {
                result += 'R';
            }
        }
        if (result.Length == 2)
        {
            result += 'X';
        }
        for(int i = 0;i < arr.Length; i++)
        {
            if (arr[i].GetOrigin() == orig)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if ((arr[j].GetDestination() == dest) && (arr[j].GetOrigin() == arr[i].GetDestination()))
                    {
                        result += 'C';
                    }
                }
            }
        }
        if (result.Length == 3)
        {
            result += 'X';
        }
        return result;
    }
    public static int GcdOfTwo(int a, int b)
    {
 
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public static int FindGCD(int a, int b, int c) 
    { 
    
        int gcdOfFirstTwo = GcdOfTwo(a, b);
        return GcdOfTwo(gcdOfFirstTwo, c);
    }
    public static PitagorienTriangle Normalize(PitagorienTriangle triangle)
    {//question 6
        int a=triangle.GetA();
        int b=triangle.GetB();
        int c=triangle.GetC();
        int gcd=FindGCD(a, b, c);
        a=a/gcd; b=b/gcd; c=c/gcd;
        PitagorienTriangle newTri = new(a, b, c);
        return newTri;
    }
    public static bool Success(int num)
    {
        int sixes = 0;
        int sum = 0;
        int curr;
        for (int i = 0; i < num; i++)
        {
            curr = Convert.ToInt32(Console.ReadLine());
            if (curr == 10)
            {
                return true;
            }
            if (curr > 5)
            {
                sixes++;
            }
            if (sixes > num / 2)
            {
                return true;
            }
            sum += curr;
        }
        double avg = (double)sum / num;
        if (avg > 5)
        {
            return true;
        }
        return false;
    }
}