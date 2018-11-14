using System;
using System.Collections.Generic;

namespace PingPongApp{

    class PingPong
    {
        public static void Main()
        {
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("------------------C# Ping Pong App-----------------");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("---------------------------------------------------");
            PingPongMethod();
        }

        public static void PingPongMethod(){
            
            Console.WriteLine("Please enter a number to run through the program.");
            string strInput = Console.ReadLine();
            int intInput = int.Parse(strInput);

            for(int i=1; i<=intInput; i++)
            {   string s; 
                if(i% 5==0 && i%3 ==0)
                {
                    s= i.ToString();
                    s= "ping-pong";
                    Console.WriteLine(s);
                } 
                else if(i%3 ==0)
                {
                    s = i.ToString();
                    s = "ping";
                    Console.WriteLine(s);
                }
                else if(i%5 ==0)
                {
                    s = i.ToString();
                    s = "pong";
                    Console.WriteLine(s);
                }
                else{
                    Console.WriteLine(i);
                }
    
            }

        }   
    
    }
}

