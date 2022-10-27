using Generic;

MyArray<int> inteiros = new MyArray<int>();

inteiros.AddElement(30);

Console.WriteLine($"{inteiros[0]}");

MyArray<string> texto = new MyArray<string>();

texto.AddElement("bla bla bla");

Console.WriteLine($"{texto[0]}");
