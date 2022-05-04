using System;
using System.Collections.Generic;
namespace StackException
{
    public class StackException : Exception
    {
        public StackException(string message) : base(message)
        {

        }
    }
    public class Operations
    {
        public int stackTop;
        public int stackCount;
        public void arrayStack()
        {
            stackTop = 0;
        }
        public void push()
        {
            if (stackTop == stackCount)
            {
                throw (new StackOverflowException("Stack overflow"));
            }
        }

    }
    public class StackProgram
    {
        public static void Main()
        {
            int s;
            Stack<int> obj = new Stack<int>();
            try
            {
                s = 15;
                obj.Push(s);
                s = 30;
                obj.Push(s);
                s = 45;
                obj.Push(s);
                s = 60;
                obj.Push(s);
                s = 75;
                obj.Push(s);
                s = 90;
                obj.Push(s);
                Console.WriteLine("The items in the stack are:");
                foreach(var item in obj)
                {
                    Console.WriteLine(item);
                }
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine("Error detected:{0} ", e.Message);
            }
            Console.WriteLine("Enter a number");
            Console.ReadKey();
            Console.WriteLine('\n');

            try
            {
                s = obj.Pop();
                Console.WriteLine(s);
                s = obj.Pop();
                Console.WriteLine(s);
                s = obj.Pop();
                Console.WriteLine(s);
                s = obj.Pop();
                Console.WriteLine(s);
                s = obj.Pop();
                Console.WriteLine(s);
            }
            catch (StackOverflowException e)
            {
                Console.WriteLine("Error Detected :{0}", e.Message);
            }
            Console.ReadKey();
            Console.WriteLine("The stack is cleared");
        }
    }
}
