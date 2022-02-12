using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Nulzi.Studio;
//using Nulzi;

////Namespace
//namespace Nulzi
//{
//    public class Youtube
//    {
//        public int subscribe;
//    }

//    namespace Studio
//    {
//        public class Youtube
//        {
//            int like;

//            public void SetLike(int value)
//            {
//                like = value;
//            }

//            public bool IsLike()
//            {
//                return like != 0;
//            }
//        }
//    }
//}

////Struct
//publci struct Youtube
//{
//    //a에 값을 대입하려면 GetA()나 public을 통해서
//    public int a;
//    //public int b = 5;//error, 대입 불가능
//    public int b;

//    public Youtube(int _a, int _b)//생성자
//    {
//        a = _a; b = _b;
//    }
//    public void GetA(int value)
//    {
//        a = value;
//    }
//}

////Enum : 열거형
//public enum Item
//{
//    Weapon,
//    Shield,
//    Potion,//마무리도 ,로
//}

public class CodeStudy : MonoBehaviour {
    //정수 자료형: sbyte(-128~127), byte(0~255), (u)short(2바이트), (u)int(4바이트), (u)long(8바이트)
    //실수 자료형: float(f), double, decimal(m)
    //문자 자료형: string, char
    //bool
    //casting: .ToString()(숫자>>문자), int.Parse()(문자>>숫자)

    //범위 지정자(지역 변수, 전역 변수), 접근 지정자(private, public, protected), static

    //기본 연산자 : +, -, *, /, %, =
    //증감 연산자 : ++, --
    //관계 연산자 : ==, <=, >=, !=
    //논리 연산자 : &&, ||, !
    //비트 연산자 : &, |, ^, ~, >>, <<

    //조건문 if, switch, (조건문) ? 참 : 거짓

    //반복문 for(;;), while(), do~while(), foreach()

    //Array 자료형[] 배열명 = {}, 자료형[] 배열멸 = new 자료형[배열 크기]
    //2차원 배열 자료형[,] 배열명 = {{}, {}}, 3차원 배열 자료형[,,] 배열명 = {{{}, {}}, {{}, {}}}

    //Collection : List, Queue, Stack, Hashtable, Dictionary, ArrayList
    //ArrayList arrayList = new ArrayList();
    //List<int> list = new List<int>;
    //Hashtable hashtable = new Hashtable();
    //Dictionary<string, int> dictionary = new Dictionary<string, int>;
    //Queue<int> queue = new Queue<int>();//자료형 고정 자유
    //Stack<int> stack = new Stack<int>();//자료형 고정 자유

    ////Namespace
    //Youtube nulzi = new Youtube();
    //Nulzi.Youtube nulzi = new Nulzi.Youtube();//같은 이름의 class면 namespace명시

    ////Struct : 상속이 불가능, 생성하지 않아도 참조 가능(new가 필요없다)
    ////struct는 값타입, class는 주소타입
    //Youtube nulzi;

    ////Enum
    //Item item;

    // Start is called before the first frame update
    void Start() {
        ////ArrayList : 추가 연산이 있지만 자료형이 정해져있지 않다
        ////add ArrayList
        //arrayList.Add(1);
        //arrayList.Add("abcde");
        //arrayList.Add(4.5);
        ////remove ArrayList
        //arrayList.Remove("abcde");//같은 내용 지우기
        //arrayList.RemoveAt(0);//인덱스 지우기
        //arrayList.RemoveRange(1, 2);//범위 지우기
        //arrayList.Clear//전부 지우기
        //print(arrayList.Count); //ArrayLIst size
        //for(int i = 0; i < arrayList.Count; i++) {
        //    print(arrayList[i]);
        //}

        //List : 자료형 고정

        ////Hashtable : 인덱스 대신 키 값으로 값을 찾는다
        //hashtable.Add("million", 10000);
        //print(hashtable["10000"]);// error
        //print(hashtable["million"]);

        ////Dictionary : 자료형 고정
        //dictionary.Add("thousan", 1000);

        ////Queue : FIFO
        ////input
        //queue.Enqueue(10);
        //queue.Enqueue(5);
        ////ouput
        ////if(queue.Count != 0) Queue 사용 시 check
        //print(queue.Dequeue());
        //print(queue.Dequeue());

        ////Stack : LIFO
        //stack.Push(3);
        //stack.Push(4);
        ////if(stack.Count != 0)
        //print(stack.Pop());
        //print(stack.Pop());

        ////Namespace
        //nulzi.SetLike(5);
        //print(nulzi.IsLike());
        //nulzi.subscribe = 5;
        //print(nulzi.subscribe);

        ////Struct
        //nulzi.a = 5;
        //nulzi.GetA(5);

        ////Enum
        //item = Item.Weapon;
        //item = Item.Shield;
        //print(item);//Shield 로그 출력
    }

    // Update is called once per frame
    void Update() {
        
    }
}
