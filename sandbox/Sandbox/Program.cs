using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle(); //myCircle is object

        myCircle._radius = 10;

        double area = myCircle.GetArea();
        
        Console.WriteLine(area);

    }
}
























    // static double AddNumbers(double x, int y)
    // {
    //  return x + y;   
    // //  double is a float but 64 bits/ twice as big as a float
    // }
    // static string MyName()
    // {
    //     return "Bob";
    // }


    // static void DisplayGreeting(string name)
    // {
    //     Console.WriteLine($"Welcome {name}, its nice to meet you");
    // }
    
        // string myName = MyName();
        // DisplayGreeting(myName);
        // double total = AddNumbers(12.234, 20);
        // Console.WriteLine(total);

        

        // WHILE LOOPppppppppppppppppppppppppppppppppppppp
        // bool done = false;

        // while (! done)
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine() == "y";
        // }

        // DO WHILEeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee
        // bool done;

        // do
        // {
        //     Console.Write("Are we done (y/n)? ");
        //     done = Console.ReadLine().ToLower() == "y";
        // }
        // while (! done);


        // FOR LOOPSsssssssssssssssssssssssssssssss
        // for (int i = 100000; i > -100000; i -= 1000)
        // {
        //     Console.WriteLine(i);
        // }
        // LISTS
        // List<string> myFriends = new List<string> {"Bobo", "Betty", "Bubba"};
        // myFriends.Add("Doug");
        // foreach (string friend in myFriends)
        // {
        //     Console.WriteLine(friend);
        // }


    // IDK WHAT THIS IS BUT
    //     int x = 21;
    //     int y = 30;
    //     int z = 40;

    //    if (x == 10 && y == 30 || z == 40)
    //     {
    //         Console.WriteLine("X is 10");
    //         Console.WriteLine("Y is fun");
    //     }
    //     else if(x==20)
    //     {
    //         Console.WriteLine("X is 20");
    //     }
    //     else
    //     {
    //         Console.WriteLine("Default Output");
    //     }
        
