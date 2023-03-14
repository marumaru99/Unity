using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//컬렉션(Collection) : C#에서는 데이터에 대한 저장을 진행할 때 특정 상황에
//쓰기 적합한 자료구조를 컬랙션으로 제공

//자료구조(Data Structure): 자료에 대한 저장, 검색, 추가, 삭제 등을 포함하는 개념

//제네릭(Generic) : <>안에 타입을 작성해 해당 자료구조에 특정 데이터만 들어갈 수 있게 처리해주는 용도로 사용

//List<T>
//리스트: 데이터를 추가 삭제 검색 정렬 등을 진행할 수 있는 자료구조
//데이터가 순서대로 저장되는 특징을 가짐

//장점 : 배열과 많이 비교됨. 동적으로 크기 조절이 가능
//단점 : 여분의 공간을 만들어주는 형태이기 때문에 배열보다는 작업이 느림
//이는 리스트의 용량이 얼마나 필요한지를 판단할 수 있으며 해당 값에 대한 설정을 진행하는 것으로 극복가능(최적화)

//자주 사용되는 문법
//리스트명.Add(값); : 리스트에 해당 값을 추가함. 여러 번 작업할 경우 순서대로 추가
//리스트명.Insert(인덱스 번호, 값); : 리스트이 인덱스 번호란에 값을 추가하는 기능
//리스트명.GetRange(시작 범위, 끝 범위); : 범위 안에 있는 요소를 따로 추출
//리스트명.Remove(값); : 리스트에 특정 값을 제거하는 기능. 같은 값이 존재할 경우 앞에 값이 제거됨
//리스트명.Contains(값); : 해당 값을 리스트가 가지고 있는 지 확인하는 함수(True/False)

//같이 활용되는 문법
//리스트 내에 있는 요소를 가로로 출력하는 문법
//foreach(자료형 변수명 in 리스트명)
//{
//    Console.WriteLine(변수명 + " ");
//}

namespace ConsoleApp1
{
    internal class Class5
    {

        public static void Main(string[] args)
        {
            List<string> item_list = new List<string>();
            //스트링타입의 데이터를 관리하는 리스트 객체 item_list

            item_list.Add("이쑤시개"); //추가
            item_list.Add("휴지");
            item_list.Add("물");
            item_list.Add("손전등");
            item_list.Add("밧줄");
           // item_list.Remove("이쑤시개"); //제거

            Console.WriteLine(item_list[0]); //자료구조 리스트는 동적으로 생성하고 삭제할 수 있는 가변 배열
            //배열의 기능 인덱스를 가짐
            //인덱스 : 배열에서 값의 위치를 찾을 수 있는 양의 정수 (0부터 배열의 길이 -1까지 주어짐)
            Console.WriteLine($"리스트가 가지고 있는 원소의 개수는 {item_list.Count}");
            Console.WriteLine($"리스트의 전체 용량은 {item_list.Capacity}");
        }
    }
}
