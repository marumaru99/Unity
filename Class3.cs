//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Class3
//    {

//        public static void Main(string[] args)
//        {
//            //C# 출력기능
//            Console.WriteLine("내용");
          
//            //C# 입력 기능
//            string input = Console.ReadLine();
//            //해당 기능은 string? 타입의 함수이기에 입력받은 값을 저장할 변수를 하나
//            //만들어서 그 값에 넘겨주는 식으로 사용
           
//            Console.WriteLine($"방금 입력한 값 : {input}");
            
//            //int input = Console.Read();
//            //해당 기능은 숫자로 저장해서 문자를 입력받으면 문자에 데한 코드 값을 리턴

//            //숫자에 대한 입력이 불편
//            //현재 입력한 값은 모두 문자로 저장됨. 이에 대한 변형이 필요.
//            //숫자를 입력해서 숫자형 데이터로 저장하는 방법

//            Console.WriteLine("정수 입력 >> ");
//            string number_input = Console.ReadLine();
//            int number = int.Parse( number_input );
//            //파싱: 구문 분석을 의미
//            //프로그래밍에서는 데이터를 분해/분석해 원하는 형태로 조립하여 다시 빼내는 작업
//            number++;
//            Console.WriteLine($"현재 number의 값 : {number}");
            
//            Console.WriteLine("실수 입력 >> ");
//            float float_input = float.Parse( Console.ReadLine());
//            //다음과 같이 파싱을 진행할 값으로 Console.ReadLine을 직접 넣어도 가능
//            //ReadLine은 입력한 값으로 , Parse에 정보가 넘어갈 것
//            Console.WriteLine($"현재 float_input의 값 : {float_input}");

//            //ToString(): Parse가 문장을 실수/정수 등으로 바꾸는 행위라면 이건 데이터를 문장으로 바꿔주는 기능
//            float PI = 3.14f;
//            string PI_String = PI.ToString();
//            Console.WriteLine(PI_String);
//        }
//    }
//}
