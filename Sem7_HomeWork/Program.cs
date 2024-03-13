// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
void Foo(int n, int m)
{
    if (n > m)
    {
        return;
    }
    Console.Write(n+" ");
    Foo(n+1, m);
}

Foo(2, 8);