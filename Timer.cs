using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Timer
    {
        //실습
        //DateTime과 입력 기능을 기반으로 타이머 프로그램 구현

        //프로그램이 시작되면 분에 대한 입력 진행
        //시작 시간은 0시 0분 0초. 1초씩 증가
        //입력한 분이 되었을 경우 x버튼을 입력하면 타이머 종료

        //60분을 넘었을 경우 1시간 단위로 전환 120분 -> 2시간

        //작업이 완료되면 Release로 설정해 진행

        static void Main(string[] args)
        {
            //Console.WriteLine("분을 입력하세요. >> ");
            //string min = Console.ReadLine();          
            //int end_min = int.Parse(min);
            //DateTime dateTime = new DateTime(0,0,0,0,0,0);
            //TimeSpan gap = dateTime - end_min;
            //int timegap = int.Parse(gap.ToString());

            //while (timegap == 0)
            //{ 
            //    dateTime = dateTime.AddSeconds(1);
            //    Console.WriteLine(dateTime.ToString());
            //    Thread.Sleep(1000);
            //    Console.Clear();

            //}

            //분에 대한 입력 진행
            Console.WriteLine("분에 대한 입력.");
            int minute = int.Parse(Console.ReadLine());

            //분에 대한 설정을 TimeSpan으로 설정.
            //TimeSpan은 시간 차이를 표현할 때 사용하는 구조체
            TimeSpan timeSpan= TimeSpan.FromMinutes(minute);//해당 분만큼 증가

            //시작 시간에 대한 설정
            TimeSpan start = TimeSpan.Zero;//초기값 00:00:00

            while(true)
            {
                if(start.TotalSeconds == timeSpan.TotalSeconds)
                {
                    Console.WriteLine("X키를 누르면 종료");
                    string input = Console.ReadLine();
                    if (input == "X") 
                    {
                        Console.Clear();
                        Console.WriteLine("작업 종료!");
                        break;
                    }
                }
                Console.WriteLine($"설정 시간 : {timeSpan.ToString()}");                           
                Console.WriteLine($"측정 시간 : {start.ToString()}");                 
                start += TimeSpan.FromSeconds(1);
                Thread.Sleep(1000);
                Console.Clear();          
            }
            
            

         
        }


    }
}
