using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    struct Rectangle
    {
        public int Width;
        public int Height;
        public int GetArea() => Width * Height;
    }

    class Program
    {
        //c# 구조체
        // 클래스와 비슷하지만 , 값 타입(Value Type)이며 가볍고 빠름
        // 주로 간단한 데이터 묶음을 만들때 사용
        struct Point
        {
            //public 어디서든 사용가능하게 권한
            //private 나만 사용하려고 하는 키워드
            public int X;
            public int Y;

            //생성자 정의 처음 생성할때 동작하는 함수
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public void Print()
            {
                Console.WriteLine($"좌표 : {X} , {Y}");
            }
        }
        //struct Point는 X, Y좌표값을 저장하는 구조체
        //구조체는 클래스랑은 다르게 new없이 사용가능
        //struct에도 생성자 사용가능 (매개 변수를 통한 초기화 가능)
        //모든 필드를 반드시 초기화해야함 (클래스와 다름)

        static void Main(string[] args)
        {
            Point[] points = new Point[2];
            points[0].X = 10;
            points[0].Y = 10;
            points[1].X = 20;
            points[1].Y = 20;
            foreach(var point in points)
            {
                Console.WriteLine($"Point : ({point.X}, {point.Y})");
            }


            /*var rect = new Rectangle { Width = 5, Height = 4 };
            
             //다른방법
             Rectangle rect;
            rect.Width = 10;
            rect.Height = 20;
             
            Console.WriteLine($"Area: {rect.GetArea()}");*/

            /*Point p; //구조체 선언(초기화 필요)
            p.X = 10;
            p.Y = 20;
            p.Print();

            //생성자 사용
            Point p1 = new Point(5, 15);
            p1.Print();*/
        }
    }
}
