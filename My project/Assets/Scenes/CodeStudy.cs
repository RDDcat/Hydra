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
//    //a�� ���� �����Ϸ��� GetA()�� public�� ���ؼ�
//    public int a;
//    //public int b = 5;//error, ���� �Ұ���
//    public int b;

//    public Youtube(int _a, int _b)//������
//    {
//        a = _a; b = _b;
//    }
//    public void GetA(int value)
//    {
//        a = value;
//    }
//}

////Enum : ������
//public enum Item
//{
//    Weapon,
//    Shield,
//    Potion,//�������� ,��
//}

public class CodeStudy : MonoBehaviour {
    //���� �ڷ���: sbyte(-128~127), byte(0~255), (u)short(2����Ʈ), (u)int(4����Ʈ), (u)long(8����Ʈ)
    //�Ǽ� �ڷ���: float(f), double, decimal(m)
    //���� �ڷ���: string, char
    //bool
    //casting: .ToString()(����>>����), int.Parse()(����>>����)

    //���� ������(���� ����, ���� ����), ���� ������(private, public, protected), static

    //�⺻ ������ : +, -, *, /, %, =
    //���� ������ : ++, --
    //���� ������ : ==, <=, >=, !=
    //�� ������ : &&, ||, !
    //��Ʈ ������ : &, |, ^, ~, >>, <<

    //���ǹ� if, switch, (���ǹ�) ? �� : ����

    //�ݺ��� for(;;), while(), do~while(), foreach()

    //Array �ڷ���[] �迭�� = {}, �ڷ���[] �迭�� = new �ڷ���[�迭 ũ��]
    //2���� �迭 �ڷ���[,] �迭�� = {{}, {}}, 3���� �迭 �ڷ���[,,] �迭�� = {{{}, {}}, {{}, {}}}

    //Collection : List, Queue, Stack, Hashtable, Dictionary, ArrayList
    //ArrayList arrayList = new ArrayList();
    //List<int> list = new List<int>;
    //Hashtable hashtable = new Hashtable();
    //Dictionary<string, int> dictionary = new Dictionary<string, int>;
    //Queue<int> queue = new Queue<int>();//�ڷ��� ���� ����
    //Stack<int> stack = new Stack<int>();//�ڷ��� ���� ����

    ////Namespace
    //Youtube nulzi = new Youtube();
    //Nulzi.Youtube nulzi = new Nulzi.Youtube();//���� �̸��� class�� namespace���

    ////Struct : ����� �Ұ���, �������� �ʾƵ� ���� ����(new�� �ʿ����)
    ////struct�� ��Ÿ��, class�� �ּ�Ÿ��
    //Youtube nulzi;

    ////Enum
    //Item item;

    // Start is called before the first frame update
    void Start() {
        ////ArrayList : �߰� ������ ������ �ڷ����� ���������� �ʴ�
        ////add ArrayList
        //arrayList.Add(1);
        //arrayList.Add("abcde");
        //arrayList.Add(4.5);
        ////remove ArrayList
        //arrayList.Remove("abcde");//���� ���� �����
        //arrayList.RemoveAt(0);//�ε��� �����
        //arrayList.RemoveRange(1, 2);//���� �����
        //arrayList.Clear//���� �����
        //print(arrayList.Count); //ArrayLIst size
        //for(int i = 0; i < arrayList.Count; i++) {
        //    print(arrayList[i]);
        //}

        //List : �ڷ��� ����

        ////Hashtable : �ε��� ��� Ű ������ ���� ã�´�
        //hashtable.Add("million", 10000);
        //print(hashtable["10000"]);// error
        //print(hashtable["million"]);

        ////Dictionary : �ڷ��� ����
        //dictionary.Add("thousan", 1000);

        ////Queue : FIFO
        ////input
        //queue.Enqueue(10);
        //queue.Enqueue(5);
        ////ouput
        ////if(queue.Count != 0) Queue ��� �� check
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
        //print(item);//Shield �α� ���
    }

    // Update is called once per frame
    void Update() {
        
    }
}
