using System;
using System.Collections.Generic;
using System.IO;

namespace taask1
{
    internal class Program
    {
        const string MyDate = @"C:\MyDate";
        
       public static void Main(string[] args)
        {
            Line line = CreateLine();
            Stack<string> stack = new Stack<string>();
            stack.Push(line.line1);
            stack.Push(line.line2);
            stack.Push(line.line3);
            foreach (string s in stack)
            {
                var a = stack.Pop();
                Console.WriteLine(a);
              
            }

        }
        public static void CreateLineInDatebase(Line line)
        {
            var file = Path.Combine(MyDate, ".txt" );
            if(File.Exists(file))
            {
                Console.WriteLine("this file has already created");
            }
            else
            {
               
                var linecontent = $"content of first line {line.line1}/n" +
                $"content of second line {line.line2}/n" +
                $"content of third line {line.line3}/n";
               
                File.WriteAllText(file, a ) ;

            }
        }

        public static Line CreateLine ()
        {
                Line line = new Line();
                Console.WriteLine("Input number of lines to write in the file");
                line.number = int.Parse(Console.ReadLine());
           
                Console.WriteLine("pls input line1 ");
                line.line1 = Console.ReadLine();
                Console.WriteLine("pls input line2 ");
                line.line2 = Console.ReadLine();
                Console.WriteLine("pls input line3 ");
                line.line3 = Console.ReadLine();
           
            return line;  

            }
        }


        public class Line
        {
            public int number;
            public string line1;
            public string line2;    
            public string line3;

        }
    }

