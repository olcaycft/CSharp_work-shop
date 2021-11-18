using System;
using System.Collections.Generic; //generic burada.

namespace StackExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // var karakterYigini = new Stack(); eğer generic olarak tanımlamazsak bu şekilde tanımlanır ve object değer ister.

            var stack = new Stack<char>(); //generic tanımlanırsa bu şekilde bizden direkt tip istiyor ve unboxing e ihtiyac olmuyor.
            stack.Push('a');
            Console.WriteLine(stack.Count);
            stack.Push('b'); 
            stack.Push('c');
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Count);
            stack.Pop();
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Count);
            
        }
    }
}
