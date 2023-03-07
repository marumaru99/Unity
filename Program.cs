using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//해당 지시자들은 과거에 필요했으나 현재에는 자동으로 처리가 되어 필요 없어짐
//그래서 투명하게 처리됨. 존재하는 이유는 이전 버전에서 사용하던 코드와의 호환성 문제

//using을 이용해 특정 위치에 있는 값들을 사용할 수 있게 해줌


//C#은 namespace를 통해 코드를 구분해 작업 진행
//유니티에서도 가능하지만 따로 네임스페이스를 처리 안하는 경우도 있음
namespace ConsoleApp1
{
    //클래스 단위로 프로그램 표현
    //기존의 C++의 경우는 메인 함수를 만들고 클래스를 설계해 호출하는 식으로 설계
    //C#은 클래스 단위로 프로그램이 굴러가기 때문에 클래스 내부에 메인 함수를 작성하는 식으로 설계
    internal class Program
    {
        //모든 c#프로그램은 메인 함수를 가지고 있어야 함
        //메인 함수는 임의의 클래스 안에 존재하게 되며, 프로그램 기준으로 1개만 존재해야함
        //파일의 이름이 클래스 단위로 표현되기 때문에 보통 클래스의 이름을 가진 클래스는
        //메인 함수를 가진 클래스로 설계되는 경우가 대부분.
        //메인 함수는 string[]을 메소드의 인자로 가지고 있으며 static으로 선언
        //string[] args에는 프로그램을 실행할 때 넣어준 문자열들이 들어가게 됨

        //static이 붙은 함수를 정적 메소드 또는 클래스 메소드라고 부르며, 클래스로부터 객체를 따로 생성하지 않고
        //직접 클래스 그 자체로 호출이 진행되는 메소드
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");//출력 기능 WriteLine
            //()안에 문장을 작성하고 작업이 끝난 뒤 띄어쓰기 작업 진행

            //Console은 System.Console NET Framework 클래스
            //콘솔에 대한 작업 관련 기능들이 들어있음
        }
    }
}
