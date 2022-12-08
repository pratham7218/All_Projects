using Stack_Oprations;

Stack stack = new Stack();
//stack.Pop();
stack.Push(1);
stack.Push("Raman");
//stack.Push(null);
stack.Push(2);
stack.Push("abc");


Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

stack.Clear();
Console.WriteLine();

stack.Push(11);
stack.Push("Suresh");
stack.Push(22);
stack.Push("xyz");

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

