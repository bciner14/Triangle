public class TriangleGenerator
{
    public string[] GenerateTriangle(int size)
    {
        string[] triangle = new string[size];
        for (int i = 0; i < size; i++)
        {
            triangle[i] = new string(' ', size - i - 1) + new string('*', 2 * i + 1);
        }
        return triangle;
    }
}
