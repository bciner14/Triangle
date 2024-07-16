using System;

public class TriangleDrawer
{
    public void DrawTriangle(string[] triangle)
    {
        foreach (string line in triangle)
        {
            Console.WriteLine(line);
        }
    }
}
