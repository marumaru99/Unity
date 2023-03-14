using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class4
    {
        //C# operator(연산자)
        //a+b - 연산자 : +, 항의 개수 : 2
        //피연산자 : a, b

        //연산자의 유형
        //1. 산술
        //2. 할당/대입
        //3. 증감
        //4. 논리
        //5. 비교
        //6. 비트
        //7. 조건
        
       public static void Main(string[] args)
        {
            //1. 산술 연산자: 프로그래밍 코드를 통해 숫자에 대한 연산을 진행할 경우 사용하는 기호
            //산술 연산자 사용 시 연산자의 우선 순위 파악해야 함
            
            //[우선 순위 기준]
            //1. 항의 개수에 따라 결정 ex)a=5, a++ +7
            //일반적으로는 단항 -> 이항 -> 삼항 순으로 우선순위를 가짐
            //단 a+처럼 후위연산일 경우에는 연산이 끝나도 난 뒤 처리
            //2. 산술 -> 비교 -> 논리 -> 대입 순으로 우선 순위 결정
            //3. 괄호를 통해 우선순위 변경 가능
            int x = 10; int y = 15; int z = 20;
            int a = x + y + z; //45
            int b = (x + y - z)*3; //15
            int c = a - b % 3;             
            Console.WriteLine(c);

            //2. 할당/대입 연산자
            //산술 연산자와 결합해 복합 대입 연산자로 많이 활용되며 값에 대한 적용을 진행
            int money = 10000;
            money += 3000; //money에 3000 더한 값을 대입(money = money+3000)
            Console.WriteLine(money);
            // +=, -=, *=, /=, %=, =

            //3. 증감 연산자 
            //값을 1증감시키거나 1을 감소시키는 연산자로 for문에서 증감식으로 많이 활용
            //++, --
            //후위연산 a++, a-- : 연산을 마무리한 뒤 항의 값을 1 증가, 감소시킴
            //전위연산 ++a, --a : 항의 값을 1 증가, 감소시킨 뒤 연산을 진행
            int j = 10;
            int i = j-- + 5 - --j; //7
            //10+5=15, j->9
            //15-(j-1) -> 15-8 = 7
            Console.WriteLine(i);
            Console.WriteLine(j);

            //과제 : 계산 순서 작성
            bool result = 4+5>2-1*7&&(12&3*2)>7||-2 != 2;
            //A&&B는 A,B결과가 둘 다 true일 경우 true를 내보냄
            //A||B는 둘 중 하나라도 true일 경우 true
            //a!=b는 a,b가 서로 다르다는 뜻
            //a&b는 a와 b를 비트 AND연산 = 논리연산

            //4. 논리 연산자, 비교 연산자
            //논리 연산자는 특정 식에 대한 결과를 판단할 때 사용하는 연산자로 주로 조건식을 세우고자 할때 사용(비교할 식이 2개 이상일 때 자주 사용)
            //&& - AND연산
            //|| - OR연산
            //!A - A의 결과를 반대로 처리하는 NOT연산
            //비교 연산자는 값에 대한 상대적인 크기 비교를 진행하는 연산자
            
            int atk = 30;
            int level = 40;
            string type = "melee";
            //만약 공격력이 10 이상, 레벨이 30이하일 경우 입장 가능
            if(atk>=10&&level<=30)
            {
                Console.WriteLine("입장 가능");
            }
            //해당 조건은 위의 조건을 만족하지 않은 상태이면 한번 더 체크 진행
            else if(type == "melee")
            {
                Console.WriteLine("입장할 수 있습니다.");
            }
            else { Console.WriteLine("입장 불가능"); }
        }
    }
}
