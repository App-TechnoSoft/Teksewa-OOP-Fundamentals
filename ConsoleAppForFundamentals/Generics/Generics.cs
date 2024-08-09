public class Generics
{
    public void PrintDetails<T, U>(T x, U y)
    {
        Console.WriteLine($"Value of X: {x} and Value of Y: {y}");
    }
}