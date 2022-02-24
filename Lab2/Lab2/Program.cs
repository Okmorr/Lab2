using Lab2;

public class Program{
    public static void Main(){
        RomanNumber x = new RomanNumber(25);
        RomanNumber y = new RomanNumber(5);

        Console.WriteLine("x: "+x.ToString());
        Console.WriteLine("y: "+y.ToString());
        Console.WriteLine("\nAdd: "+RomanNumber.Add(x, y));
        Console.WriteLine("Sub: "+RomanNumber.Sub(x, y));
        Console.WriteLine("Mul: "+RomanNumber.Mul(x, y));
        Console.WriteLine("Div: "+RomanNumber.Div(x, y));

        RomanNumber z = new RomanNumber(1256);
        RomanNumber v = new RomanNumber(670);
        RomanNumber b = new RomanNumber(127);

        Console.WriteLine("\nSort: ");
        RomanNumber[] numbers = { x, y, z, v };
        Array.Sort(numbers);
        foreach (RomanNumber num in numbers)
        Console.WriteLine("- " + num.ToString());

        Console.WriteLine("\nClone: ");
        Console.WriteLine("x = " + x);
        var g = (RomanNumber)x.Clone();
        x = (RomanNumber)y.Clone();
        Console.WriteLine("g = " + g);
        Console.WriteLine("x = " + x);

        Console.WriteLine("\nCompar: \ny & y");
        Console.WriteLine(y.CompareTo(y));
        Console.WriteLine("\nCompar: \nz & y");
        Console.WriteLine(z.CompareTo(y));
    }
}