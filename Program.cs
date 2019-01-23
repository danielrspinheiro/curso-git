using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,,,] mat = new double[2, 3, 3,4];
            Console.WriteLine(mat.Length);
            Console.WriteLine(mat.Rank);
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
