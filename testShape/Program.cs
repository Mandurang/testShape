using System;
using System.Runtime.InteropServices;

internal class Program
{
    [DllImport("DllShape.dll")]
    public static extern void triangleType(double catetA, double catetB, double catetC);
    private static void Main(string[] args)
    {
        double catetA = 3;
        double catetB = 4;
        double catetC = 5;

        
        triangleType(catetA, catetB, catetC);
    }
}