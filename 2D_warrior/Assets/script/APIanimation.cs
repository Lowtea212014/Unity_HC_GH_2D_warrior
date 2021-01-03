using UnityEngine;

public class APIanimation : MonoBehaviour
{
    // Start is called before the first frame update
    //修飾詞 類別 欄位
    public Transform TraA;
    public Transform tester;
    public Camera Cam;
    public GameObject peg;
    public SpriteRenderer peglayer;
    private void Start()
    {
        //非靜態屬性
        //取得
        //欄位.屬性
        print("座標：" + TraA.position);
        //取得
        print("圖片顏色：" + peglayer.color);
        print("圖片圖層：" + peg.layer);
        //設定
        //欄位.屬性 指定 值;
        tester.position = new Vector3(2, 0, 0);
        //設定
        peglayer.color = new Color(0, 0, 0, 100);
        peg.layer = 5;
        peglayer.flipX =true;

        //靜態屬性
        print("攝影機數量：" + Camera.allCamerasCount);
            
        Cam.backgroundColor = new Color(0,0,0,0);
    }

    // Update is called once per frame
    // 使用方法
    void Update()
    {
        //非靜態方法
        //使用：
        //欄位.方法(對應的引數)
        tester.Rotate(0,0,5);
        tester.Translate(0.5f,0,0, Space.World);
    }
}
