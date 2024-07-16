using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Lütfen üçgenin boyutunu giriniz: ");
        int size;
        while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.Write("Geçerli bir pozitif tamsayı giriniz: ");
        }

        TriangleGenerator generator = new TriangleGenerator();
        string[] triangle = generator.GenerateTriangle(size);

        TriangleDrawer drawer = new TriangleDrawer();
        drawer.DrawTriangle(triangle);
    }
}
