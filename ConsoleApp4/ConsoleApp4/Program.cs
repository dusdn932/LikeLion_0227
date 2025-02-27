using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp4
{
    struct Point
    {
        public string name;
        public int Kor;
        public int Math;
        public int Eng;

        public void Print()
        {
            Console.WriteLine($"{name}\t{ Kor}\t{ Eng}\t{ Math}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[3]; ;
            for (int i=0; i < points.Length; i++)
            {
                Console.WriteLine("학생성적을 입력하세요.");
                Console.WriteLine("학생이름 : ");
                points[i].name = Console.ReadLine();
                Console.WriteLine("국어 : ");
                points[i].Kor = int.Parse(Console.ReadLine());
                Console.WriteLine("영어 : ");
                points[i].Eng = int.Parse(Console.ReadLine());
                Console.WriteLine("수학 : ");
                points[i].Math = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("이름       국어      영어      수학");
            foreach (var point in points)
            {
                point.Print();
            }
        }
    }
}
