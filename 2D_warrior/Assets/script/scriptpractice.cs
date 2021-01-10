using UnityEngine;

public class scriptpratice : MonoBehaviour
{
    public int a = 7;
    public int b = 4;

    private void Start()
    {
        //比較運算子
        //傳回布林值
        print(a > b);
        print(a < b);
        print(a == b);
        print(a != b);

        //邏輯運算子
        //並且 &&
        //有一個F 結果就是 F
        print(true && true); //t
        print(true && false);
        print(false && false);

        //或者 || 
        //有一個T 結果為 T
        print(true || true);
        print(true || false);
        print(false || true);
        print(false || false);
    }
}
