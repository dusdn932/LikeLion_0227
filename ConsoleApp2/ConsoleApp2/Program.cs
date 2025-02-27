using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//네임스페이스
//클래스 , 함수 , 변수 이름이 충돌하는것을 방지하기 위해 사용된다.
/*namespace dev1
{
    class MyClass
    {
        public static void SayHello()
        {
            Console.WriteLine("안녕하세요 !MyNameSpace의 MyClass입니다.");
        }
    }
}*/
namespace ConsoleApp2
{
    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("안녕하세요 메인팀입니다.");
        }
        //일반적인 함수
        static int Add(int a, int b)
        {
            return a + b;
        }
        //화살표 함수
        //중괄호 {} return 생략가능
        static int AddArrow(int a, int b) => a + b;
        //일반적인함수
        static void PrintMessage()
        {
            Console.WriteLine("안녕하세요.");
        }
        //화살표함수
        static void PrintMessageArrow() => Console.WriteLine("안녕하세요!");
        //열거형
        //Enumeration enum
        //숫자 값에 이름을 부여하는 자료형
        //가독성을 높이고, 의미 있느 값으로 표현 가능
        //기본적으로 첫번째 값은 0부터 시작하며 1씩 즈가
        //기본적인 enum사용법
        enum DayOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        //2. enum 값 변경(0부터 시작하지 않기)
        enum StatusCode
        {
            Success = 200,
            BadRequest = 400,
            Unaauthorized = 401,
            NotFound = 404
        }

        enum WepponType
        {
            Sword,
            Bow,
            Staff
        }
        static void ChooseWeapon(WepponType a)
        {
            if(a == WepponType.Bow)
                Console.WriteLine("활을 선택했습니다.");
            else if (a == WepponType.Sword)
                Console.WriteLine("검을 선택했습니다.");
            else if (a == WepponType.Staff)
                Console.WriteLine("지팡이를 선택했습니다.");
        }
        static void Main(string[] args)
        {;
            ChooseWeapon(WepponType.Bow);



            /*StatusCode status = StatusCode.NotFound;
            Console.WriteLine(status);
            Console.WriteLine((int)status);*/

            //숫자를 직접 사용하지 않고, 의미 있는 이름으로 관리가능
            /*DayOfWeek today = DayOfWeek.Wednesday;
            Console.WriteLine(today);
            Console.WriteLine((int)today);*/

            //Math클래스 사용
            //수학적 계산
            /*Console.WriteLine($"Pi: {Math.PI}");
            Console.WriteLine($"Square root of 25: {Math.Sqrt(25)}");
            Console.WriteLine($"Power (2^3): {Math.Pow(2, 3)}");
            Console.WriteLine($"Round(3.75): {Math.Round(3.75)}");*/

            //c#화살표 함수
            //c#에서 화살표 함수 => 람다 표현식이라고도 하며
            //간결한 방식으로 함수를 정의할 수있습니다.

            /*PrintMessage();
            PrintMessageArrow();
            Console.WriteLine(Add(3, 5));
            Console.WriteLine(AddArrow(3, 5));*/
            /*SayHello();
            dev1.MyClass.SayHello();*/
        }
    }
}
