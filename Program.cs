using System;

namespace c_review
{
    class Program
    {
        static void Main(string[] args)
        {
            int x= 30;
            Console.WriteLine("Hello There! " + x );

            if (x < 30) {
                Console.WriteLine ("x is less than thirty!");

                       }
             else if (x ==30) {
                 Console.WriteLine( "x is thirty!");
                              }
             else {
                 Console.WriteLine (" x is greater than thirty!");
                 }
             
             
            
            int a =1;
            switch (a) {
                case 1:
                  Console.WriteLine("value is 1!");
                 break;
                case 2:
                  Console.WriteLine ("value is 2!");
                  break;
                case 3:
                  Console.WriteLine ("Value is 3!");
                  break;
                default:
                  Console.WriteLine (" Howdy!");
                  break;    
            }
        }
    }
}
