using System;

namespace EnumTesting
{
    [Flags] public enum Colors // public is the modifier, enum is variable  (bopgr) 01101 =13  (looking at this compared to the colors below will show if we have it on or off. it helps with multi-selection
    {
        red=1, //                                                       00001
        green=2, //0 *orig, but now we are doubling the colors          00010
        yellow = 3,  //                                                 00011
        purple=4, //1                                                   00100
        orange=8, //2                                                   01000
        black=16 //3                                                    10000
    }

    public class Program 
    {
        static void Main(string[] args)
        {
            Colors c; // can hold the colors  (you don't need EnumTesting)
            //Colors c1; //this is unused atm
            //int i=1; // can hold a number

            c = Colors.red; // this makes it so it can start from here as a the first.
                            //c = Colors.green; //c has the value of 0 and green from now if we see the color green it has the constant of 0, but its not an integer
                            //c1 = Colors.blue; // c1 is dif from c as they're seperate instances
                            //i = (int)c; (int makes the c a integer because it has it infront of it)
                            //Console.WriteLine(i); // turns it into the integer
                            //         000001
                            //         000100
                            //         a or b yes...>
                            //         000101


            c = Colors.red | Colors.black | Colors.green; // adding black will change that last one to 10000 and say true    /purple makes it false, and switching to green will fix it
            //c = 10101         10011 is what it changes to when looking for yellow
            //    10000    colors.Black
            // a and b
            //    00000     the value will come back as 0 


            Colors isyellowon = c & Colors.yellow;    //isblackon
            bool test = isyellowon == Colors.yellow;  //isblackon was orig way and showed only black as true
            //switching green with purple makes it so that yellow will be true and shown as on.
            Console.WriteLine(test);
            Console.WriteLine($"int:{(int)c} enum:{c}"); //prints the recognized name in the enum or it will print the number if no name is given.
            return;
                                                         //Console.WriteLine(c); // turns the enum into the name of the integer instead of the value
            c++; //this changed it to the next one. "adds 1"
                 //Console.WriteLine(c); // this now shows up as blue.




            //Console.WriteLine(i); // turns it into the integer
            //Console.WriteLine($"int:{(int)c} enum:{c}");              <-Loops
            //c++;       

            Console.WriteLine($"int:{(int)c} enum:{c}");
            c++;
        }
    }
}
