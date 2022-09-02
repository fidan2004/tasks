using System;
using System.Collections.Generic;

namespace taask4
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<string> parts = new List<string>();
            parts.Add("one");
            parts.Add("two");
            parts.Add("three");
            parts.Add("four");
            Console.WriteLine(parts.Count);
               foreach(string part in parts)
            {
                Console.WriteLine(part);
            }

            Console.WriteLine(parts.Contains("one"));
            parts.Clear();
            Console.WriteLine("Elements after using clear: " + parts.Count);
        }

        public static void Remove(List<string> parts)
        {
            Console.WriteLine(parts.Remove("two"));
        }
      
        public static bool Contains(List<string> parts)
        {
            return parts.Contains("one");
        }
        public  void Clear(List<string> parts)
        {
           parts.Clear(); 
            
        }

    }
}
