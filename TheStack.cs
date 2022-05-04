using System;
using System.Collections.Generic;

class MyStack
{
	static public void Main()
	{
		Stack<double> stackone = new Stack<double>();

		stackone.Push(555);
		stackone.Push(369);
		stackone.Push(6734);
		stackone.Push(6.95);
		stackone.Push(656.9);
		stackone.Push(453.87);
		Console.WriteLine("The elements in stack are:");

		foreach (var item in stackone)
		{
			Console.WriteLine(item);
		}
		stackone.Push(10);
		Console.WriteLine("The elements in stack after a new push operation are:");

		foreach (var item in stackone)
		{
			Console.WriteLine(item);
		}
		stackone.Pop();
		Console.WriteLine("The elements in stack after pop operation are:");
		foreach (var item in stackone)
		{
			Console.WriteLine(item);
		}
	}
}

