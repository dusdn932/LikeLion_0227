/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    class Program
    {
        struct Item {
            const int Max_ITEMS = 10;

            //아이템 배열 (이름 저장)
            static string[] itemNames = new string[Max_ITEMS];
            static int[] itemCounts = new int[Max_ITEMS];
            //아이템 추가 함수
            public void AddItem(string name, int count)
            {
                for (int i = 0; i < Max_ITEMS; i++)
                {
                    if (itemNames[i] == name) //이미 있는 아이템이면 개수증가
                    {
                        itemCounts[i] += count;
                        return;
                    }
                }
                //빈슬롯에 새로운 아이템 추가
                for (int i = 0; i < Max_ITEMS; i++)
                {
                    if (itemNames[i] == null)
                    {
                        itemNames[i] = name;
                        itemCounts[i] = count;
                        return;
                    }
                }
                Console.WriteLine("인벤토리가 가득 찼습니다.");
            }
            //아이템 제거 함수
            public void RemoveItem(string name, int count)
            {
                for (int i = 0; i < Max_ITEMS; i++)
                {
                    if (itemNames[i] == name)//이름하고 같은지
                    {
                        if (itemCounts[i] >= count)//개수가 충분하면 차감
                        {
                            itemCounts[i] -= count;
                            if (itemCounts[i] == 0)
                            {
                                itemNames[i] = null;
                            }
                            return;
                        }
                        else
                        {
                            Console.WriteLine("아이템 개수가 부족합니다!");
                            return;
                        }
                    }
                }
                Console.WriteLine("아이템을 찾을수 없습니다.");
            }

            //인벤토리 출력함수
            public void ShowInventory()
            {
                Console.WriteLine("현재 인벤토리 : ");
                bool isEmpty = true;
                for (int i = 0; i < Max_ITEMS; i++)
                {
                    if (itemNames[i] != null)
                    {
                        Console.WriteLine($"{itemNames[i]} (x{itemCounts[i]})");
                        isEmpty = false;
                    }
                }
                if (isEmpty)
                {
                    Console.WriteLine("인벤토리가 비어 있습니다.");
                }
            }
        }
        //최대 아이템 개수(배열 크기)
        
        static void Main(string[] args)
        {
            Item inven = new Item();
            //테스트 : 아이템 추가
            inven.AddItem("포션", 5);
            inven.AddItem("칼", 1);
            inven.AddItem("포션", 3);

            inven.ShowInventory();
            //아이템 사용
            Console.WriteLine("포션 2개 사용");
            inven.RemoveItem("포션", 2);
            inven.ShowInventory();

            //테스트 : 없는 아이템 제거
            Console.WriteLine("방패 1개 제거 시도");
            inven.RemoveItem("방패", 1);
            inven.ShowInventory();

            //테스트 : 모든 초과사용
            Console.WriteLine("포션 7개 사용");
            inven.RemoveItem("포션", 7);
            inven.ShowInventory();
        }
    }
}*/
/*using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp7
{
    class Program
    {
        struct Player
        {
            public string[] Chr;//캐릭터
            public int X;
            public int Y;
            public Player(string[] chr, int x, int y)
            {
                Chr = chr;
                X = x;
                Y = y;
            }
            public void Draw()
            {
                for (int i = 0; i < Chr.Length; i++)
                {
                    //콘솔좌표 설정 플레이어X 플레이어Y
                    Console.SetCursorPosition(X, Y + i);
                    //문자열배열 출력
                    Console.WriteLine(Chr[i]);
                }
            }
            public void Move(ConsoleKey Key)
            {
                switch (Key)
                {
                    case ConsoleKey.UpArrow: if (Y > 0) Y--; break;
                    case ConsoleKey.DownArrow: if (Y < Console.WindowHeight - 1) Y++; break;
                    case ConsoleKey.LeftArrow: if (X > 0) X--; break;
                    case ConsoleKey.RightArrow: if (X < Console.WindowWidth - 1) X++; break;
                    case ConsoleKey.Spacebar: Console.Write("미사일키"); break;
                    case ConsoleKey.Escape: return;
                }
            }
        }


        static void Main(string[] args)
        {
            string[] playerchr = new string[]
            {
                "->",
                ">>>",
                "->"
            };//배열 문자열로 그리기
            Player player = new Player(playerchr, 0, 12);
            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = false;

            //시간 1초 루프
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            long prevSecond = stopwatch.ElapsedMilliseconds; //1000분의 1초


            while (true)
            {
                long currentSecond = stopwatch.ElapsedMilliseconds; //현재 시간 가져오기
                if (currentSecond - prevSecond >= 10)
                {
                    Console.Clear();
                    player.Draw();



                    keyInfo = Console.ReadKey(true);//키 입력받기 (화면 출력 X)
                    //방향키 입력에 따른 좌표 변경
                    if (keyInfo.Key == ConsoleKey.Spacebar)
                    {

                    }
                    else if (keyInfo.Key == ConsoleKey.Escape)
                    {
                        return;
                    }
                    else
                    {
                        player.Move(keyInfo.Key); // 플레이어 이동
                    }




                    prevSecond = currentSecond;//이전시간 업데이트
                }

            }

        }
    }
}
*/