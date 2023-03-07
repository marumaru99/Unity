using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Example
    {
        int global_Variable;
        public static int data_value = 5;
        //C++ / C#의 차이점
        //C++에서 public은 접근 제한 지시자로 클래스 내부에서 설정하면 해당 범위에 존재하는 값 전체를 public으로 처리

        //C#에서는 접근제한자로 , 변수 앞에, 메소드 앞에 직접 붙여서 접근 여부 표현

        public void Method_Example01()
        {
            int local_Variable = 100;

            Console.WriteLine($"클래스 내부의 전역변수 : {global_Variable}");
            Console.WriteLine($"클래스 내부 메소드에서 만들어진 지역변수 : {local_Variable}");
        }
    }
    internal class Class2
    {
        public int data;
        static void Main(string[] args )
        {
            Console.WriteLine(data);
            //오류나는 이유
            //1.static 선언이 되어있기 때문에 static으로 만들어진 변수는 받아올 수 있음
            //따라서 static은 클래스 그 자체가 가지고 있는 값으로 사용하게 해줌(메인 함수는 Class2에 있기에 Class2를 찍어줄 필요는 없음)
            //2.클래스의 필드 값을 메인에서 사용하기 위해서는 클래스 생성을 진행해야함

            //클래스가 밖에 따로 만들어졌을 경우 해당 값을 메인에서 쓰기 위해서는 객체 생성을 진행해야 함
            //클래스 생성 방법
            //클래스명 클래스변수명(레퍼런스명) = new 생성자명();
            Example example = new Example();
            //C++에서는 Example* example = new Example();로 포인터를 이용한 동절 할당으로 생성을 진행 또는
            //Example example;과 같이 선언만 진행하는 식으로 작업했다면
            //C#에서는 new 키워드에 의한 할당으로 생성 진행
            //delete코드 따로 없이 자동으로 삭제 처리가 되도록 설계

            example.Method_Example01(); //example의 Method_Example01을 호출
            Console.WriteLine(Example.data_value);
            //클래스 그 자체가 가지고 있는 값으로써 사용 가능(static)
        }
    }
}
