using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSGame
{
    class Game
    {
        string[] var = { "가위", "바위", "보" };

        int com, user;

        public Game(int user)
        {
            Random random = new Random();
            com = random.Next(1, 4);
            this.user = user;
        }

        public void Play()
        {
            if (com == user)
            {
                Console.WriteLine("컴퓨터 : " + var[com - 1] + " 유저 : " + var[user - 1]);
                Console.WriteLine("비겼습니다");
            }
            else if (user == 1 && com == 3 || user == 2 && com == 1 || user == 3 && com == 2)
            {
                Console.WriteLine("컴퓨터 : " + var[com - 1] + " 유저 : " + var[user - 1]);
                Console.WriteLine("유저가 이겼습니다");
            }
            else if (user == 1 && com == 2 || user == 2 && com == 3 || user == 3 && com == 1)
            {
                Console.WriteLine("컴퓨터 : " + var[com - 1] + " 유저 : " + var[user - 1]);
                Console.WriteLine("컴퓨터가 이겼습니다");
            }
            
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. 가위, 2. 바위, 3. 보, 4. 종료");

                Console.Write("값을 입력하세요 : ");
                try
                {
                    int n = int.Parse(Console.ReadLine());

                    if (n == 4)
                    {
                        break;
                    }
                    else if (n > 4)
                    {
                        Console.WriteLine("4보다 큰 값을 입력하였습니다");
                    }

                    Game game = new Game(n);
                    game.Play();
                }
                catch(FormatException)
                {
                    Console.WriteLine("잘못된 값을 입력하였습니다");
                }

                Console.WriteLine();

            }
            
        }
    }
}
