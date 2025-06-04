using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(Success(4));
    }
    public static string Decode(string input,int code)
    {
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