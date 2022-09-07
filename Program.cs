using System;
using System.Collections.Generic;

namespace Algorithms {
    class Program {

        static void Main(string[] args) {

            Stack<string> stack = new Stack<string>();

            System.Console.WriteLine("Start Main");
            stack.Push("Main");
            System.Console.WriteLine("Start ResponseBuilder");
            stack.Push("ResponseBuilder");
            Console.WriteLine("END " + stack.Pop());
            System.Console.WriteLine("Start CallExternalService");
            stack.Push("CallExternalService");
            Console.WriteLine("END " + stack.Pop());
            System.Console.WriteLine("Start ParseExternalData");
            stack.Push("ParseExternalData");
            Console.WriteLine("END " + stack.Pop());

        }
    }
}