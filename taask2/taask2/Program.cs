using System;
using System.IO;

namespace taask2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string a = @"C:\MyDate";
            int total = GetFilesNumber(a);
            Console.WriteLine(total);
        }
        static int GetFilesNumber(String b)
        {

            int total = Directory.GetFiles(b).Length;
            String[] directories = Directory.GetDirectories(b);
            for (int i = 0; i < total; i++)
                total += GetFilesNumber(directories[i]);

            return total;
        }
    }
}
