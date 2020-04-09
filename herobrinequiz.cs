// is herobrine mad at you? (c#)
using System;
using System.Threading;

class quiz
{
    readonly string[][][][][][][][][][] hi;
    static void rpq(ref string c, ref int e, int a1, int a2, int a3, int a4)
    {
        while (true)
        {
            c = Console.ReadLine();
            switch (c)
            {
                case "1":
                    e += a1;
                    break;
                case "2":
                    e += a2;
                    break;
                case "3":
                    e += a3;
                    break;
                case "4":
                    e += a4;
                    break;
                default:
                    Console.WriteLine("\x1B[33mpls select one of the options above.\x1B[37m");
                    continue;
            }
            break;
        }
        Console.Clear();
    }
    
    static void Main(string[] args)
    {
        int p = 10; // herobrine love
        string choice = "";

        Console.WriteLine("quiz: \x1B[33mIS HERBORINE MAD AT YOU??\x1B[37m");
        Thread.Sleep(3000);
        Console.Clear();

        Console.WriteLine("\x1B[33m- what do you think about notch?\x1B[37m \n1. he sux \n2. idk but he created minecraft \n3. bald \n4. luv him cuz hes god");
        Thread.Sleep(3000);
        rpq(ref choice, ref p, 3, 2, -1, -2);
        Console.WriteLine("\x1B[33m- are you jojofag?\x1B[37m \n1. jojotards need to die \n2. yare yare daze \n3. what jojo means? \n4. minecraft>>");
        rpq(ref choice, ref p, -3, -2, 2, 1);
        Console.WriteLine("\x1B[33m- what do you think about women right?\x1B[37m \n1. stfu women \n2. women deserves a good and secure life like all another person in our society. \n3. i like hentai \n4. idk just want potato");
        rpq(ref choice, ref p, 2, -1, -2, 1);
        Console.WriteLine("\x1B[33m- what r the values of the other variables of y²=x³+ax+b considering that y = 2.6?\x1B[37m \n1. 69 \n2. covid dude i forgot how to think \n3. fuck you herobrine \n4. IM LOSING BRAINCELLS");
        rpq(ref choice, ref p, -2, 3, -2, -1);

        Thread.Sleep(1000);
        Console.WriteLine("\x1B[33mherobrine is judging you...\x1B[37m");
        Thread.Sleep(4000);
        Console.Clear();

        if ((0 > p) == true)
        {
            Console.WriteLine("\x1B[33mHEROBRINE HATES YOU.\x1B[37m \nif i was you, i would be really scared now. he may want to: \n- kill your dog; - burn your mansion; suggest nanatsu no taizai; \nand other crimes... be careful...");
            Thread.Sleep(4000);
        }
        else if ((0 < p && p <= 5) == true)
        {
            Console.WriteLine("\x1B[33mHEROBRINE THINKS YOU ARE ANNOYING.\x1B[37m \nif i was you, i would be ashamed now. \nhe may want to troll you, be careful...");
            Thread.Sleep(4000);
        }
        else if ((5 > p && p <= 10) == true)
        {
            Console.WriteLine("\x1B[33mHEROBRINE DISLIKES YOU.\x1B[37m \nhe wont do anything, simply cuz he doesnt care enough. \nbtw stay alert...");
            Thread.Sleep(4000);
        }
        else if ((10 > p && p <= 15) == true)
        {
            Console.WriteLine("\x1B[33mHEROBRINE LIKES YOU.\x1B[37m \nhe wont do anything, simply cuz he doesnt care enough. \nbtw stay online on skype...");
            Thread.Sleep(4000);
        }
        else if ((15 > p && p <= 20) == true)
        {
            Console.WriteLine("\x1B[33mHEROBRINE THINKS YOU ARE A NICE PERSON.\x1B[37m \nhe wont do anything, simply cuz he doesnt care enough. \nbtw stay alert...");
            Thread.Sleep(4000);
        }
        else if ((p > 20) == true)
        {
            Console.WriteLine("\x1B[33mHEROBRINE LOVES YOU!! :333\x1B[37m \nhe may wanna sleep with your dad and play mc survival with you! \n(you are lucky.......)");
            Thread.Sleep(4000);
        } else {
            Console.WriteLine("\x1B[33midk\x1B[37m");
            Thread.Sleep(2000);
        }
    }
}
