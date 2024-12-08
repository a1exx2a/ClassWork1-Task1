namespace Lesson4;

class Program
{
    static void Main(string[] args)
    {
        int y = 0;
        int[] x = {1,2,3,4,5,6,7,8,9,10};
        foreach (int i in x) {
            y = y + i;
        }
        Console.WriteLine(y);

    }
}
