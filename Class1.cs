using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        //C#의 데이터 타입
        //Bool(논리형) : 결과에 대한 표현 (true/false)
        bool isWalk = true;
        //Numeric(숫자에 대한 표현)
        //정수
        short sh = -32768;
        int i = 214748347;
        long l = 214748347L; //long은 운영체제에 따라 크기가 변환되는 자료형
        //실수
        float f = 0.123456789f;//소수점 9자리 까지는 오차없이 표현
        double d = 0.123456789012345678; //double타입은 약 소수점 18자리 까지는 오차없이 표현
        decimal de = 0.12346M; //고정 소수점이라는 방식으로 소수를 표현

        //실수 계산방식
        //1. 부동 소수점 : 작은 메모리에 큰 소수를 저장할 수 있음. 정확성이 떨어짐
        //2. 고정 소수점 : 연산 속도가 빠르고 정확성이 높음. 메모리가 많이 필요함

        //문자/문장
        char ch = 'ㅇ'; //문자에 대한 표현 시 ''로 작업을 진행. 영문자, 특수문자, 한글 가능
        string s = "문장"; //C++때부터 사용하던 문자열 객체 string

        static void Main(string[] args)
        {
            #region 시간
            /*//시간에 대한 클래스 DateTime이 추가됨
            DateTime dateTime = new DateTime(2023, 03, 16, 11, 0, 0);
            while(true) //무제한 반복
            {
                dateTime = dateTime.AddSeconds(1);
                Console.WriteLine(dateTime.ToString());
                Thread.Sleep(1000);//쓰레드 환경에서 1초간 정지
                //쓰레드(Thread) : 프로세스 내에서 실행되는 흐름의 단위
                Console.Clear(); //콘솔창 화면 지우기
            }
            //ToString()을 통해 객체의 값을 문자로 표현하는 기능이 추가됨*/
            #endregion

            int MaxInteger = int.MaxValue;
            //uint타입은 unsigned int를 의미하며 -값을 계산하지 않고 
            //그 수치만큼 +해 양의 정수를 더 많이 표현하기 위함
            int MinInteger = int.MinValue;

            Console.WriteLine($"Int의 최대값 = {MaxInteger}");
            Console.WriteLine($"Int의 최소값 = {MinInteger}");

            string s = null; //null이 추가됨
            //C, C++에서 데이터가 없다라는 의미로 NULL을 사용하는데 
            //C#에서는 소문자 null을 사용

            //null을 가질 수 있는 데이터 타입은 Reference타입.
            //Value타입일 경우 null을 가질 수 없음
            //int a = null; 불가능

            //Nullable Type
            //일반적으로 Value타임은 null을 가지지 못하기 때문에 이를 위해 만들어진 표현
            //자료형? 으로 표현
            int? i = null;
            i = 100; //초기화 진행하면 값으로 적용
        }
    }
}
