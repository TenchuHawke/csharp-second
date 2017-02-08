using System;
using System.Collections.Generic;

namespace ConsoleApp {
    public class Program {
        public static void SayHello(string name)
        {
            System.Console.WriteLine("Hello to you, {0}", name);
        }
        public static void Main(){
            SayHello("Jeff");
        }

    }
}
