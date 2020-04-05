// random word creator (c#)
using System;
using System.Threading;

class big
{
    public string txt = "";
    public static void qbig()
    {
        big biggie = new big();
        Random r = new Random();
        while (true)
        {
            string abc = "qwertyuiopasdfghjklzxcvbnm"; 
            int f = r.Next(0, 25); int t = r.Next(0, 33);
            int a = biggie.txt.Length; a = t;
            for (; t >= a;) {
                biggie.txt += abc[f];
                break;
            }
            Console.WriteLine($"$: {biggie.txt}");
            Thread.Sleep(50);
            Console.Clear();
        }
    }
} // 1. a infinite one

class small : big
{
    public static void qsmall()
    {
        while (true)
        {
            Random r = new Random();
            string abc = "qwertyuiopasdfghjklzxcvbnm";
            string txt = "";
            int f = r.Next(0, 25);
            for (int i = 0; i < r.Next(5, 30); i++)
            {
                txt += abc[r.Next(abc.Length)];
            }
            Console.WriteLine($"$: {txt}");
            Thread.Sleep(1000);
            continue;
        }
    }
} // 2. a list of random ones

class sys : small
{
    static void Main(string[] args)
    {
        Console.WriteLine("RANDOM WORD CREATOR!");
        Thread.Sleep(2000);
        Console.Clear();

        Console.WriteLine("what type of *random word* do you want? \n1. a infinite one \t2. a list of random ones \n<pls input the corresponding number>");
         while (true)
        {
            string c = Console.ReadLine();
            switch (c)
            {
                case "1":
                    Console.WriteLine("alright, here you go...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    qbig();
                    break;
                case "2":
                    Console.WriteLine("alright, here you go...");
                    Thread.Sleep(2000);
                    Console.Clear();
                    qsmall();
                    break;
                default:
                    Console.WriteLine("<pls input one of the corresponding numbers>");
                    Thread.Sleep(2000);
                    continue;
            }
        }
    }
}
