using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getsubject : MonoBehaviour
{
    public SpriteRenderer picturecolor;
    public GameObject peg;
    public Transform peglocal;
    // Start is called before the first frame update
    private void Start()
    {
        //取得
         print("圖片顏色：" + picturecolor.color);
         print("圖片圖層：" + peg.layer);

        //設定
        picturecolor.color = new Color(0, 0, 0, 100);
        peg.layer = 5;
        picturecolor.flipX = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        peglocal.Translate(0.5f , 0, 0, Space.World);
    }
}
